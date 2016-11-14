using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkApiForNet.Returns
{
    public class WallReturns
    {
        public class WallGetReturn
        {
            public class rc
            {
                public long count;
                public List<Classes.PostClass> items;
            }
            public rc response;
        }
    }
}
