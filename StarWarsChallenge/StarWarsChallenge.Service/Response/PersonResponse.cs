using StarWarsChallenge.Data.Models;
using System;
using System.Collections.Generic;

namespace StarWarsChallenge.Service.Response
{
    public class PersonResponse
    {
        public PersonResponse()
        { }
        public PersonResponse(Person personInfo, Planet homeworld, List<Species> species, List<string> films, List<Vehicle> vehicles, List<string> starships)
        {
            Name = personInfo.Name;
            Height = personInfo.Height;
            Mass = personInfo.Mass;
            Hair_color = personInfo.Hair_color;
            Skin_color = personInfo.Skin_color;
            Eye_color = personInfo.Eye_color;
            Birth_year = personInfo.Birth_year;
            Gender = personInfo.Gender;
            Created = personInfo.Created;
            Edited = personInfo.Edited;
            Url = personInfo.Url;
            Films = films;
            Species = species;
            Vehicles = vehicles;
            Starships = starships;
            Homeworld = homeworld;

        }
        public string Name { get; set; }
        public string Height { get; set; }
        public string Mass { get; set; }
        public string Hair_color { get; set; }
        public string Skin_color { get; set; }
        public string Eye_color { get; set; }
        public string Birth_year { get; set; }
        public string Gender { get; set; }
        public string Url { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public Planet Homeworld { get; set; }
        public List<string> Films { get; set; }
        public List<Species> Species { get; set; }
        public List<Vehicle> Vehicles { get; set; }
        public List<string> Starships { get; set; }


    }
}
