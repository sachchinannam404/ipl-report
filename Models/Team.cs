
using System.Collections.Generic;

namespace myapp.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public string? HomeGround { get; set; }
        public List<Player>? Players { get; set; }
    }
}
