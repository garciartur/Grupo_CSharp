﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTheater_System
{
    public class Movie
    {
        public string Name { get; private set; }
        /*public DateTime RegistrationDate { get; private set; }
        public int Runtime { get; set; }
        public int AgeRating { get; set; }
        public bool Dubbed { get; set; }
        public string Director { get; set; }
        public string Cast { get; set; }
        public string Description { get; set; }
        public string Distribution { get; set; }
        public string Genre { get; set; }*/
        
        public Movie(string name)
        {
            Name = name;
        }

    }
}
