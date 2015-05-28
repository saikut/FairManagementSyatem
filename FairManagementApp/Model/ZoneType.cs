using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FairManagementApp.Model
{
    public class ZoneType
    {
        private int zoneId { get; set; }

        public string zonetype { get; set; }


        public int ZoneId
        {
            get { return zoneId; }
            set { zoneId = value; }
        }

        public string Zonetype
        {
            get { return zonetype; }
            set { zonetype = value; }
        }
    }
}
