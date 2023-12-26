using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DNS.Repporting.Tool.Models
{
    public class DnsLogs
    {
        public DateTime timestamp { get; set; }
        public string domain { get; set; }
        public string root { get; set; }
        public string tracker { get; set; }
        public bool encrypted { get; set; }
        public string protocol { get; set; }
        public string clientIp { get; set; }
        public string client { get; set; }
        public Device device { get; set; }
        public string status { get; set; }
        public List<Reason> reasons { get; set; }
    }
}



