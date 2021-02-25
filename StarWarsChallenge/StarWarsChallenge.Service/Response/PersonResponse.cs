using StarWarsChallenge.Data.Models;
using System;
using System.Collections.Generic;

namespace StarWarsChallenge.Service.Response
{
    public class PersonResponse
    {
        public PersonResponse()
        { }
        public PersonResponse(Person person, Planet homeworld, List<Species> species, List<string> films, List<Vehicle> vehicles, List<string> starships)
        {
            Name = person.Name;
            Height = person.Height;
            Mass = person.Mass;
            Hair_color = person.Hair_color;
            Skin_color = person.Skin_color;
            Eye_color = person.Eye_color;
            Birth_year = person.Birth_year;
            Gender = person.Gender;
            Created = person.Created;
            Edited = person.Edited;
            Url = person.Url;
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
