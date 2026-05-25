using Microsoft.AspNetCore.Mvc.RazorPages;
using myapp.Models;
using System.Collections.Generic;

namespace myapp.Pages
{
    public class WinnersModel : PageModel
    {
        public List<Winner> Winners { get; set; }

        public void OnGet()
        {
            // This is a temporary solution. The data should be read from the ipl.csv file.
            Winners = new List<Winner>
            {
                new Winner { Year = 2008, Winner = "Rajasthan Royals", RunnerUp = "Chennai Super Kings" },
                new Winner { Year = 2009, Winner = "Deccan Chargers", RunnerUp = "Royal Challengers Bangalore" },
                new Winner { Year = 2010, Winner = "Chennai Super Kings", RunnerUp = "Mumbai Indians" },
                new Winner { Year = 2011, Winner = "Chennai Super Kings", RunnerUp = "Royal Challengers Bangalore" },
                new Winner { Year = 2012, Winner = "Kolkata Knight Riders", RunnerUp = "Chennai Super Kings" },
                new Winner { Year = 2013, Winner = "Mumbai Indians", RunnerUp = "Chennai Super Kings" },
                new Winner { Year = 2014, Winner = "Kolkata Knight Riders", RunnerUp = "Kings XI Punjab" },
                new Winner { Year = 2015, Winner = "Mumbai Indians", RunnerUp = "Chennai Super Kings" },
                new Winner { Year = 2016, Winner = "Sunrisers Hyderabad", RunnerUp = "Royal Challengers Bangalore" },
                new Winner { Year = 2017, Winner = "Mumbai Indians", RunnerUp = "Rising Pune Supergiant" },
                new Winner { Year = 2018, Winner = "Chennai Super Kings", RunnerUp = "Sunrisers Hyderabad" },
                new Winner { Year = 2019, Winner = "Mumbai Indians", RunnerUp = "Chennai Super Kings" },
                new Winner { Year = 2020, Winner = "Mumbai Indians", RunnerUp = "Delhi Capitals" },
                new Winner { Year = 2021, Winner = "Chennai Super Kings", RunnerUp = "Kolkata Knight Riders" },
                new Winner { Year = 2022, Winner = "Gujarat Titans", RunnerUp = "Rajasthan Royals" },
                new Winner { Year = 2023, Winner = "Chennai Super Kings", RunnerUp = "Gujarat Titans" },
            };
        }
    }
}
