using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApiForNet.ParamStructs
{
    // <summary>
    /// Параметры wall.get
    /// </summary>
    public struct WallGetParams
    {
        public WallGetParams (int? own_id = null)
        {
            owner_id = own_id;
            domain = null;
            offset = null;
            count = null;
            filter = null;
            extended = null;
            fields = new List<string>();
        }
        public int? owner_id;
        public string domain;
        public int? offset;
        public int? count;
        public string filter;
        public int? extended;
        public List<string> fields;
    }

    // <summary>
    /// Параметры wall.createComment
    /// </summary>
    public struct WallCreateCommentParams
    {
        public WallCreateCommentParams (bool gag = true)
        {
            owner_id = null;
            post_id = 0;
            from_group = null;
            message = null;
            reply_to_comment = null;
            attachments = new List<string>();
            sticker_id = null;
            guid = null;
        }

        public int? owner_id;
        public int post_id;
        public int? from_group;
        public string message;
        public int? reply_to_comment;
        public List<string> attachments;
        public int? sticker_id;
        public string guid;
    }
}
