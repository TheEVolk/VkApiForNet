using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApiForNet.Classes
{
    public class MessageClass
    {
        public int id;
        public int user_id;
        public int from_id;
        public int date;
        public int read_state;
        //public int? out; - dont know, for fix this
        public string title;
        public string body;
        public object attachments;//Fix
        public MessageClass[] fwd_messages;
        public int emoji;
        public int important;
        public int deleted;
        public int? random_id;
        //Chat:
        public int? chat_id;
        public int[] chat_active;
        public int? users_count;
        public int? admin_id;
        public string action;
        public int? action_mid;
        public string action_email;
        public string action_text;
        public string photo_50;
        public string photo_100;
        public string photo_200;
    }
}
