namespace DNS.Repporting.Tool.Models
{
    public class Privacy
    {
        public List<Blocklist> blocklists { get; set; }
        public List<Native> natives { get; set; }
        public bool disguisedTrackers { get; set; }
        public bool allowAffiliate { get; set; }
    }


}
