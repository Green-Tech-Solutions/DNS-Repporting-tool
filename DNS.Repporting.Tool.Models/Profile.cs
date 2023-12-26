namespace DNS.Repporting.Tool.Models
{
    public class Profile
    {
        public string name { get; set; }
        public Security security { get; set; }
        public Privacy privacy { get; set; }
        public ParentalControl parentalControl { get; set; }
        public List<Denylist> denylist { get; set; }
        public List<Allowlist> allowlist { get; set; }
        public Settings settings { get; set; }
    }


}
