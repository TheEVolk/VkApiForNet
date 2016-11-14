using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApiForNet.ParamStructs
{
    // <summary>
    /// Параметры users.get
    /// </summary>
    public struct UsersGetParams
    {
        public UsersGetParams (bool gag = true)
        {
            user_ids = new List<string>();
            fields = new List<string>();
            name_case = null;
        }

        public List<string> user_ids;
        public List<string> fields; 
        public string name_case;
    }
}
