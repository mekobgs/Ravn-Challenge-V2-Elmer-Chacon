using Newtonsoft.Json;
using StarWarsChallenge.Data.Models;
using StarWarsChallenge.Service.Interfaces;
using StarWarsChallenge.Service.Response;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace StarWarsChallenge.Service.Service
{
    public class StarWarsService : IStarWarsService
    {
        public async Task<IEnumerable<PersonResponse>> GetPeople(int page)
        {
            var people = await RequestPeople(page);
            if (people == null) return new List<PersonResponse>();
            var personResponse = await Task.WhenAll(people.Select(async p => await CreatePersonResponse(p)));
            return personResponse;
        }

        private async Task<IEnumerable<Person>> RequestPeople(int page)
        {
            var peoplePage = await GetRequest<PaginatedResponse<Person>>($"https://swapi.dev/api/people/?page={page}");
            return peoplePage.Results;
        }

        private async Task<T> GetRequest<T>(string url)
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<T>(apiResponse);
                }
            }
        }

        private async Task<PersonResponse> CreatePersonResponse(Person person)
        {
            var homeworldRequest = GetPlanet(person.Homeworld);
            var speciesTasks = person.Species.Select(s => GetSpecies(s));
            var vehicleTasks = person.Vehicles.Select(s => GetVehicle(s));

            var homeworld = await homeworldRequest;
            var species = (await Task.WhenAll(speciesTasks)).ToList();
            var vehicles = (await Task.WhenAll(vehicleTasks)).ToList();
            return new PersonResponse(
                person,
                homeworld,
                species,
                person.Films,
                vehicles,
                person.Starships
             );
        }

        private async Task<Planet> GetPlanet(string url) => await GetRequest<Planet>(url);

        private async Task<Species> GetSpecies(string url) => await GetRequest<Species>(url);
        private async Task<Vehicle> GetVehicle(string url) => await GetRequest<Vehicle>(url);
    }
}
