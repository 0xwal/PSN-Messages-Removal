namespace Message_Deleter
{
    sealed partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPassBox = new System.Windows.Forms.TextBox();
            this.txtEmailBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnApplyMembersCount = new System.Windows.Forms.Button();
            this.numMembersCount = new System.Windows.Forms.DomainUpDown();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassBox
            // 
            this.txtPassBox.Location = new System.Drawing.Point(52, 42);
            this.txtPassBox.Name = "txtPassBox";
            this.txtPassBox.PasswordChar = '*';
            this.txtPassBox.Size = new System.Drawing.Size(150, 20);
            this.txtPassBox.TabIndex = 13;
            // 
            // txtEmailBox
            // 
            this.txtEmailBox.Location = new System.Drawing.Point(52, 16);
            this.txtEmailBox.Name = "txtEmailBox";
            this.txtEmailBox.Size = new System.Drawing.Size(150, 20);
            this.txtEmailBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pass";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(127, 68);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Email";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.lblUsername);
            this.groupBox.Controls.Add(this.txtPassBox);
            this.groupBox.Controls.Add(this.txtEmailBox);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Controls.Add(this.label2);
            this.groupBox.Controls.Add(this.btnLogin);
            this.groupBox.Location = new System.Drawing.Point(58, 12);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(225, 96);
            this.groupBox.TabIndex = 12;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Authentication";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(14, 73);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 13);
            this.lblUsername.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.Location = new System.Drawing.Point(1, 171);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(341, 271);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Members Count";
            // 
            // btnApplyMembersCount
            // 
            this.btnApplyMembersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyMembersCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApplyMembersCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyMembersCount.Location = new System.Drawing.Point(289, 1);
            this.btnApplyMembersCount.Name = "btnApplyMembersCount";
            this.btnApplyMembersCount.Size = new System.Drawing.Size(53, 20);
            this.btnApplyMembersCount.TabIndex = 19;
            this.btnApplyMembersCount.Text = "Apply";
            this.btnApplyMembersCount.UseVisualStyleBackColor = true;
            // 
            // numMembersCount
            // 
            this.numMembersCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numMembersCount.Items.Add("All");
            this.numMembersCount.Location = new System.Drawing.Point(203, 147);
            this.numMembersCount.Name = "numMembersCount";
            this.numMembersCount.ReadOnly = true;
            this.numMembersCount.Size = new System.Drawing.Size(139, 20);
            this.numMembersCount.TabIndex = 20;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = global::Message_Deleter.Properties.Resources.Ellipsis;
            this.pictureBox.Location = new System.Drawing.Point(1, 114);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(341, 23);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(4, 155);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(35, 13);
            this.lblCount.TabIndex = 21;
            this.lblCount.Text = "Count";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 443);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnApplyMembersCount);
            this.Controls.Add(this.numMembersCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Deleter";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtPassBox;
        private System.Windows.Forms.TextBox txtEmailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnApplyMembersCount;
        private System.Windows.Forms.DomainUpDown numMembersCount;
        private System.Windows.Forms.Label lblCount;
    }
}

