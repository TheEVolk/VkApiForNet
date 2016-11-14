//===================================================================
//= /\/\/\/\/\  /\        /\    /\/\/\    /\          /\      /\    =
//= /\          /\        /\  /\      /\  /\          /\    /\      =
//= /\            /\    /\    /\      /\  /\          /\  /\        =
//= /\/\/\/\/\    /\    /\    /\      /\  /\          /\/\          =
//= /\              /\/\      /\      /\  /\          /\/\          =
//= /\              /\/\      /\      /\  /\          /\  /\        =
//= /\/\/\/\/\       /\         /\/\/\    /\/\/\/\/\  /\    /\      =
//===================================================================
//Проект: VkApi
//Описание: Библиотека для связи с ВконтактеAPI
//
//Файл: Messages.cs
//Описание: Работа с Message методами
//===================================================================

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApiForNet.Methods
{
    public class Messages
    {
        public VkApi refApi;

        public Messages (VkApi vk)
        {
            refApi = vk;
        }

        /// <summary>
        /// Отправить сообщение
        /// </summary>
        /// <param name="param">Параметры</param>
        public string Send (ParamStructs.MessagesSendParams param)
        {
            VkApiMethod api = new VkApiMethod("messages.send");
            api["access_token"] = refApi.userToken;
            api["v"] = refApi.version;
            if(param._long.HasValue)
                api["long"] = param._long.Value.ToString();
            if(param.attachment!=null)
                api["attachment"] = Main.ContactString(param.attachment.ToArray(), ",");
            if(param.chat_id.HasValue)
                api["chat_id"] = param.chat_id.Value.ToString();
            if(param.domain!=null)
                api["domain"] = param.domain;
            if(param.forward_messages.Count!=0)
                api["forward_messages"] = Main.ContactString(param.forward_messages.ToArray(), ",");
            if(param.lat.HasValue)
                api["lat"] = param.lat.Value.ToString();
            if(param.message!=null)
                api["message"] = param.message;
            if(param.notification.HasValue)
                api["notification"] = param.notification.Value ? "1" : "0";
            if(param.peer_id.HasValue)
                api["peer_id"] = param.peer_id.Value.ToString();
            if(param.random_id.HasValue)
                api["random_id"] = param.random_id.Value.ToString();
            if(param.sticker_id.HasValue)
                api["sticker_id"] = param.sticker_id.Value.ToString();
            if(param.user_id.HasValue)
                api["user_id"] = param.user_id.Value.ToString();
            if(param.user_ids!=null)
                api["user_ids"] = Main.ContactString(param.user_ids.ToArray(), ",");
            return api.Send();
        }

        /// <summary>
        /// Отправить сообщение
        /// </summary>
        /// <param name="param">Параметры</param>
        public Returns.MessagesReturns.MessagesGetReturn Get (ParamStructs.MessagesGetParams param)
        {
            VkApiMethod api = new VkApiMethod("messages.get");
            api["access_token"] = refApi.userToken;
            api["v"] = refApi.version;
            api["out"] = param._out ? "1" : "0";
            api["count"] = param.count.ToString();
            if(param.filters.HasValue)
                api["filters"] = param.filters.Value.ToString();
            if(param.last_message_id.HasValue)
                api["last_message_id"] = param.last_message_id.Value.ToString();
            if(param.offset.HasValue)
                api["offset"] = param.offset.Value.ToString();
            if(param.preview_length.HasValue)
                api["preview_length"] = param.preview_length.Value.ToString();
            if(param.time_offset.HasValue)
                api["time_offset"] = param.time_offset.Value.ToString();
            return JsonConvert.DeserializeObject<Returns.MessagesReturns.MessagesGetReturn>(api.Send());
        }

        /// <summary>
        /// Изменить имя беседы
        /// </summary>
        /// <param name="param">Параметры</param>
        public Returns.MessagesReturns.MessagesEditChatReturn EditChat (ParamStructs.MessagesEditChatParams param)
        {
            VkApiMethod api = new VkApiMethod("messages.editChat");
            api["access_token"] = refApi.userToken;
            api["v"] = refApi.version;
            api["chat_id"] = param.chat_id.ToString();
            api["title"] = param.title;
            return JsonConvert.DeserializeObject<Returns.MessagesReturns.MessagesEditChatReturn>(api.Send());
        }

        /// <summary>
        /// Добавить пользователя в беседу
        /// </summary>
        /// <param name="param">Параметры</param>
        public Returns.MessagesReturns.MessagesAddChatUserReturn AddChatUser (ParamStructs.MessagesAddChatUserParams param)
        {
            VkApiMethod api = new VkApiMethod("messages.addChatUser");
            api["access_token"] = refApi.userToken;
            api["v"] = refApi.version;
            api["chat_id"] = param.chat_id.ToString();
            api["user_id"] = param.user_id.ToString();
            return JsonConvert.DeserializeObject<Returns.MessagesReturns.MessagesAddChatUserReturn>(api.Send());
        }

        /// <summary>
        /// Кикнуть пользователя из беседы
        /// </summary>
        /// <param name="param">Параметры</param>
        public Returns.MessagesReturns.MessagesRemoveChatUserReturn RemoveChatUser (ParamStructs.MessagesRemoveChatUserParams param)
        {
            VkApiMethod api = new VkApiMethod("messages.removeChatUser");
            api["access_token"] = refApi.userToken;
            api["v"] = refApi.version;
            api["chat_id"] = param.chat_id.ToString();
            api["user_id"] = param.user_id.ToString();
            return JsonConvert.DeserializeObject<Returns.MessagesReturns.MessagesRemoveChatUserReturn>(api.Send());
        }
    }
}
