namespace DNS.Repporting.Tool.Models
{
    public class Logs
    {
        public bool enabled { get; set; }
        public Drop drop { get; set; }
        public int retention { get; set; }
        public string location { get; set; }
    }


}
