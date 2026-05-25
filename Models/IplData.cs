namespace myapp.Models
{
    public class IplData
    {
        public int Id { get; set; }
        public int Season { get; set; }
        public string? Team1 { get; set; }
        public string? Team2 { get; set; }
        public string? TossWinner { get; set; }
        public string? TossDecision { get; set; }
        public string? Winner { get; set; }
        public string? PlayerOfMatch { get; set; }
        public string? Venue { get; set; }
        public string? City { get; set; }
    }
}
