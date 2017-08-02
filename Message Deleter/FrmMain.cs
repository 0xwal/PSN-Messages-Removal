using PSNLib;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Threading.Tasks.Task;

namespace Message_Deleter
{
    public sealed partial class FrmMain : Form
    {
        private PSAPI _ps;
        private Control _cnt;
        public FrmMain()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            SizeChanged += delegate
            {
                groupBox.Location = new Point((Width / 2) - (groupBox.Width / 2), groupBox.Location.Y);
                pictureBox.Location = new Point((Width / 2) - (pictureBox.Width / 2), pictureBox.Location.Y);
            };
            MinimumSize = new Size(350, 500);
            numMembersCount.SelectedIndex = 0;
            numMembersCount.Items.AddRange(Enumerable.Range(1, 50).ToArray());
            numMembersCount.KeyPress += (k, p) => {
                if (p.KeyChar != (char)Keys.Enter)
                    return;
                btnApplyMembersCount.PerformClick();
            };
            #region ApplyButton btnApplyMembersCount
            btnApplyMembersCount.Height = numMembersCount.Height;
            btnApplyMembersCount.FlatStyle = FlatStyle.Popup;
            btnApplyMembersCount.Location = 
                new Point(numMembersCount.Location.X + ((numMembersCount.Width / 2) + 2),
                numMembersCount.Location.Y);
            btnApplyMembersCount.Click += delegate
            {
                Execute(RetrieveData);
            };
            #endregion
           
            #region ContextMenuStrip cms
            ContextMenuStrip cms = new ContextMenuStrip();
            cms.Items.Add("Delete");
            cms.Click += delegate
            {
                Execute(() =>
                {
                    foreach (ListViewItem message in listView.SelectedItems)
                    {
                        var threadId = message.SubItems[3].Text;
                        if (_ps.Messages.Delete(threadId))
                        {
                            message.Remove();
                        }
                    }
                });
            };
            #endregion
            #region listView
            listView.View = View.Details;
            listView.GridLines = true;
            listView.FullRowSelect = true;
            listView.ShowItemToolTips = true;
            int lstViewWidth = listView.Size.Width;
            listView.Columns.Add("ID", 50);
            lstViewWidth -= 50;
            lstViewWidth /= 2;
            listView.Columns.Add("Message", lstViewWidth);
            listView.Columns.Add("Members", lstViewWidth);
            listView.ContextMenuStrip = cms;
            listView.KeyDown += (sender, e) =>
            {
                if (e.KeyCode != Keys.A || !e.Control) return;
                listView.MultiSelect = true;
                foreach (ListViewItem item in listView.Items)
                {
                    item.Selected = true;
                }
            };
            listView.SizeChanged += delegate
            {
                lstViewWidth = (listView.Size.Width / 2) - 20;
                listView.Columns[1].Width = lstViewWidth;
                listView.Columns[2].Width = lstViewWidth;
            };
            #endregion
        }
        private void RetrieveData()
        {
            if (_ps == null)
                return;
            listView.Items.Clear();
            var allMessages = _ps.Messages.GetAllMessages();
            int msgsLen = allMessages.Length;
            lblCount.Text = msgsLen.ToString();
            int membsCount;
            for (int i = 0; i < msgsLen; i++)
            {
                string[] theMemebers = allMessages[i].ThreadMembers;
                membsCount = theMemebers.Length;
                if (numMembersCount.SelectedIndex == 0 || membsCount == int.Parse(numMembersCount.Text))
                    listView.Items.Add(new ListViewItem(new[] { (i + 1).ToString(), allMessages[i].LastBody, $"[{ membsCount }] => " + string.Join(", ", theMemebers), allMessages[i].ThreadId }));
            }
        }
        private Control GetFoucus()
        {
            foreach (Control item in Controls)
            {
                if (item.Focused)
                    return item;
            }
            return default(Control);
        }
        private void PicBox(bool state)
        {
            pictureBox.Visible = state;
        }
        private bool LogIn()
        {
            try
            {
                _ps = new PSAPI(txtEmailBox.Text, txtPassBox.Text);
                lblUsername.Text = _ps.Profile.OnlineId;
                return _ps != null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        private void LockMe()
        {
            bool stat = btnLogin.Enabled;
            if (stat)
                _cnt = GetFoucus();
            btnLogin.Enabled = !stat;
            PicBox(stat);
            Controls.OfType<Control>().ToList().ForEach(x =>
            {
                if (x.GetType() != typeof(PictureBox))
                    x.Enabled = !stat;
            });
            if (!stat)
                _cnt?.Focus();
        }
        private async void Execute(Action act)
        {
            LockMe();
            await Run(act);
            LockMe();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmailBox.TextLength < 1 || txtPassBox.TextLength < 1)
            {
                MessageBox.Show("Error, Fill the details..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Execute(() =>
            {
                if (LogIn())
                {
                    RetrieveData();
                }
            });
        }
    }
}
