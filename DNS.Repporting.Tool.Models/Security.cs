namespace DNS.Repporting.Tool.Models
{
    public class Security
    {
        public bool threatIntelligenceFeeds { get; set; }
        public bool aiThreatDetection { get; set; }
        public bool googleSafeBrowsing { get; set; }
        public bool cryptojacking { get; set; }
        public bool dnsRebinding { get; set; }
        public bool idnHomographs { get; set; }
        public bool typosquatting { get; set; }
        public bool dga { get; set; }
        public bool nrd { get; set; }
        public bool ddns { get; set; }
        public bool parking { get; set; }
        public bool csam { get; set; }
        public List<Tld> tlds { get; set; }
    }


}
