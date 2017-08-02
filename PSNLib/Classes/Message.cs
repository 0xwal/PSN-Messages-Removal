using PSNLib.Models;
using TheHttp;

namespace PSNLib
{
    public class Messages
    {
        private readonly PSAPI _context;
        private Messages() { }
        internal Messages(PSAPI context)
        {
            _context = context;
        }
        public struct Message
        {
            public string[] ThreadMembers { get; internal set; }
            public string Sender { get; internal set; }
            public string LastBody { get; internal set; }
            public string ThreadId { get; internal set; }
        }
        public Message[] GetAllMessages()
        {
            var res = Http.Get(Consts.APIEndpoints.MESSAGE_THREADS_URL + "/?fields=threadMembers,threadNameDetail,threadThumbnailDetail,threadProperty,latestMessageEventDetail&limit=200&offset=0", null, null, new { Authorization = "Bearer " + Variables.AccessToken });
            if (res == null || res.HasError)
                return new Message[0];
            var mess = res.AsJson()["threads"];
            int messagesLen = mess.Length;
            Message[] messages = new Message[messagesLen];
            string nullString = "Con not read";
            for (int i = 0; i < messagesLen; i++)
            {
                messages[i] = new Message()
                {
                    ThreadId = mess[i]["threadId"],
                };
                mess[i].TryGetValue("latestMessageEventDetail", out dynamic obj);
                messages[i].Sender = obj != null ? obj["sender"]["onlineId"] : nullString;
                messages[i].LastBody = obj != null ? obj["messageDetail"]["body"] : nullString;
                var membs = mess[i]["threadMembers"];
                int membsLen = membs.Length;
                messages[i].ThreadMembers = new string[membsLen];
                for (int x = 0; x < membsLen; x++)
                {
                    messages[i].ThreadMembers[x] = membs[x]["onlineId"];
                }
            }
            return messages;
        }
        public bool Delete(string threadId)
        {
            var res = Http.Delete(Consts.APIEndpoints.MESSAGE_THREADS_URL + "/" + threadId + "/users/me", null, null, new { Authorization = "Bearer " + Variables.AccessToken });
            return !res.HasError;
        }
    }
}
