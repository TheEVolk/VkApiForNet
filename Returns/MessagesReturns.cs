using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApiForNet.Returns
{
    public class MessagesReturns
    {
        public class MessagesGetReturn
        {
            public class rc
            {
                public long count;
                public List<Classes.MessageClass> items;
            }
            public rc response;
        }

        public class MessagesEditChatReturn
        {
            public int response;
        }

        public class MessagesAddChatUserReturn
        {
            public int response;
        }

        public class MessagesRemoveChatUserReturn
        {
            public int response;
        }
    }
}
