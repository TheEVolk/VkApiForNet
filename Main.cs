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
//Файл: Main.cs
//Описание: Низкоуровневая работа с VkApi
//===================================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace VkApiForNet
{
    class Main
    {
        public static string ContactString (Array arr, string sep)
        {
            if(arr.Length==0)
                return "";
            string ret = "";
            for(int i = 0; i<arr.Length; i++)
            {
                ret+=arr.GetValue(i).ToString()+sep;
            }
            return ret.Remove(ret.Length-sep.Length);
        }
    }

    public class VkApiMethod
    {
        public string method;
        private Dictionary<string, string> p = new Dictionary<string, string>();

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="met">Метод</param>
        public VkApiMethod (string met)
        {
            method = met;
        }

        public VkApiMethod AddParam (string key, string value)
        {
            p[key] = value;
            return this;
        }

        public string this[string key]
        {
            get
            {
                return p[key];
            }
            set
            {
                p[key] = value;
            }
        }

        public string Send ()
        {
            try
            {
                using(var request = new HttpRequest())
                {
                    RequestParams rp = new RequestParams();
                    foreach(var k in p)
                        rp[k.Key] = k.Value;
                    return request.Post("https://api.vk.com/method/" + method, rp).ToString();
                }
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        } 
    }
}
