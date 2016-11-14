using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApiForNet.Methods
{
    public class Wall
    {
        public VkApi refApi;

        public Wall (VkApi vk)
        {
            refApi = vk;
        }

        /// <summary>
        /// Получить пользователей
        /// </summary>
        /// <param name="param">Параметры</param>
        public Returns.WallReturns.WallGetReturn Get (ParamStructs.WallGetParams param)
        {
            VkApiMethod api = new VkApiMethod("wall.get");
            api["access_token"] = refApi.userToken;
            api["v"] = refApi.version;

            if(param.fields.Count!=0)
                api["fields"] = Main.ContactString(param.fields.ToArray(), ",");
            if(param.count!=null)
                api["count"] = param.count.Value.ToString();
            if(param.domain!=null)
                api["domain"] = param.domain;
            if(param.extended!=null)
                api["extended"] = param.extended.Value.ToString();
            if(param.filter!=null)
                api["filter"] = param.filter;
            if(param.offset!=null)
                api["offset"] = param.offset.Value.ToString();
            if(param.owner_id!=null)
                api["owner_id"] = param.owner_id.Value.ToString();

            return JsonConvert.DeserializeObject<Returns.WallReturns.WallGetReturn>(api.Send());
        }

        /// <summary>
        /// Добавить комментарий к записи
        /// </summary>
        /// <param name="param">Параметры</param>
        public string CreateComment (ParamStructs.WallCreateCommentParams param)
        {
            VkApiMethod api = new VkApiMethod("wall.createComment");
            api["access_token"] = refApi.userToken;
            api["v"] = refApi.version;

            if(param.attachments.Count!=0)
                api["attachments"] = Main.ContactString(param.attachments.ToArray(), ",");
            if(param.from_group!=null)
                api["from_group"] = param.from_group.Value.ToString();
            if(param.guid!=null)
                api["guid"] = param.guid;
            if(param.owner_id!=null)
                api["owner_id"] = param.owner_id.Value.ToString();
            if(param.message!=null)
                api["message"] = param.message;
            if(param.post_id!=null)
                api["post_id"] = param.post_id.ToString();
            if(param.reply_to_comment!=null)
                api["reply_to_comment"] = param.reply_to_comment.Value.ToString();
            if(param.sticker_id!=null)
                api["sticker_id"] = param.sticker_id.Value.ToString();
            //return JsonConvert.DeserializeObject<Returns.WallReturns.WallGetReturn>(api.Send());
            return api.Send();
        }
    }
}
