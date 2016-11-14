using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApiForNet.ParamStructs
{
    /// <summary>
    /// Параметры messages.send
    /// </summary>
    public struct MessagesSendParams
    {
        public MessagesSendParams (bool gag = true)
        {
            user_id = null;
            random_id = null;
            peer_id = null;
            domain = null;
            chat_id = null;
            user_ids = null;
            message = null;
            lat = null;
            _long = null;
            attachment = new List<string>();
            forward_messages = new List<int>();
            sticker_id = null;
            notification = null;
        }

        public int? user_id;
        public int? random_id;
        public int? peer_id;
        public string domain;
        public int? chat_id;
        public List<int> user_ids;
        public string message;
        public float? lat;
        public float? _long;
        public List<string> attachment;
        public List<int> forward_messages;
        public int? sticker_id;
        public bool? notification;
    }

    /// <summary>
    /// messages.get параметры
    /// </summary>
    public struct MessagesGetParams
    {
        public MessagesGetParams (bool gag = true)
        {
            _out = false;
            offset = null;
            count = 5;
            time_offset = null;
            filters = null;
            preview_length = null;
            last_message_id = null;
        }

        public bool _out;
        public int? offset;
        public int count;
        public int? time_offset;
        public int? filters;
        public int? preview_length;
        public int? last_message_id;
    }

    /// <summary>
    /// Параметры messages.editChat
    /// </summary>
    public struct MessagesEditChatParams
    {
        public MessagesEditChatParams (int cid = 0, string tit = "")
        {
            chat_id = cid;
            title = tit;
        }

        public int chat_id;
        public string title;
    }

    /// <summary>
    /// Параметры messages.addChatUser
    /// </summary>
    public struct MessagesAddChatUserParams
    {
        public MessagesAddChatUserParams (int cid = 0, int uid = 0)
        {
            chat_id = cid;
            user_id = uid;
        }

        public int chat_id;
        public int user_id;
    }

    /// <summary>
    /// Параметры messages.removeChatUser
    /// </summary>
    public struct MessagesRemoveChatUserParams
    {
        public MessagesRemoveChatUserParams (int cid = 0, int uid = 0)
        {
            chat_id = cid;
            user_id = uid;
        }

        public int chat_id;
        public int user_id;
    }
}
