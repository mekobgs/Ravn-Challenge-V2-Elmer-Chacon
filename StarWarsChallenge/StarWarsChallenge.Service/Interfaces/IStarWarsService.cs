using StarWarsChallenge.Service.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StarWarsChallenge.Service.Interfaces
{
    public interface IStarWarsService
    {
        Task<IEnumerable<PersonResponse>> GetPeople(int page);
    }
}
