using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApplication
{
    /*储存单个的巡航方式*/
    class Section
    {
        public String mode { get; set; }
        public List<Item> itemList = new List<Item>();
        public Boolean hasCI = false;
    }
}
