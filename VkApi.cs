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
//Файл: VkApi.cs
//Описание: Главный класс для работы с Вконтакте
//===================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApiForNet
{
    public class VkApi
    {
        public string userToken;
        public string version = "5.59";
        public Classes.UserClass thisUser;

        public Methods.Messages messages;
        public Methods.Users users;
        public Methods.Wall wall;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="token">Токен</param>
        public VkApi (string token)
        {
            userToken = token;
            messages = new Methods.Messages(this);
            users    = new Methods.Users(this);
            wall     = new Methods.Wall(this);

            thisUser = users.Get(new ParamStructs.UsersGetParams(true)).response[0];
        }
    }
}
