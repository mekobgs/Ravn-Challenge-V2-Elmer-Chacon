﻿using System;
using System.Collections.Generic;

namespace StarWarsChallenge.Data.Models
{
    public class Vehicle
    {
        public string Cargo_capacity { get; set; }
        public string Consumables { get; set; }
        public string Cost_in_credits { get; set; }
        public DateTime Created { get; set; }
        public string Crew { get; set; }
        public DateTime Edited { get; set; }
        public string Length { get; set; }
        public string Manufacturer { get; set; }
        public string Max_atmosphering_speed { get; set; }
        public string Model { get; set; }
        public string Name { get; set; }
        public string Passengers { get; set; }
        public List<string> Pilots { get; set; }
        public List<string> Films { get; set; }
        public string Url { get; set; }
        public string Vehicle_class { get; set; }
    }
}
