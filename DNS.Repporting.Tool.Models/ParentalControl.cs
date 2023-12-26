namespace DNS.Repporting.Tool.Models
{
    public class ParentalControl
    {
        public List<Service> services { get; set; }
        public List<Category> categories { get; set; }
        public bool safeSearch { get; set; }
        public bool youtubeRestrictedMode { get; set; }
        public bool blockBypass { get; set; }
    }


}
