using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS.Repporting.Tool.Models
{
    public class Device
    {
        public string id { get; set; }
        public string name { get; set; }
        public string model { get; set; }
        public int queries { get; set; }
    }


}
