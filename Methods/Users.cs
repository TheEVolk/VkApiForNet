using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApiForNet.Methods
{
    public class Users
    {
        public VkApi refApi;

        public Users (VkApi vk)
        {
            refApi = vk;
        }

        /// <summary>
        /// Получить пользователей
        /// </summary>
        /// <param name="param">Параметры</param>
        public Returns.UsersReturns.UsersGetReturn Get (ParamStructs.UsersGetParams param)
        {
            VkApiMethod api = new VkApiMethod("users.get");
            api["access_token"] = refApi.userToken;
            api["v"] = refApi.version;
            
                if(param.fields.Count!=0)
                    api["fields"] = Main.ContactString(param.fields.ToArray(), ",");
                if(param.user_ids.Count!=0)
                    api["user_ids"] = Main.ContactString(param.user_ids.ToArray(), ",");
                if(param.name_case!=null)
                    api["name_case"] = param.name_case;
            
            return JsonConvert.DeserializeObject<Returns.UsersReturns.UsersGetReturn>(api.Send());
        }
    }
}
