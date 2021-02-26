using System.Collections.Generic;

namespace StarWarsChallenge.Service.Response
{
    public class PaginatedResponse<T>
    {
        public int Count { get; set; }
        public string Next { get; set; }
        public object Previous { get; set; }
        public List<T> Results { get; set; }
    }
}
