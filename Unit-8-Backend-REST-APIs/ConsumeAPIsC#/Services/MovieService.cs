using moviesAPI.Models;
using System.Net.Sockets;
using System.Text.Json;

namespace ConsumeAPIsC_.Services
{
    public class MovieService
    {
        private readonly HttpClient _httpClient;

        public MovieService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7223/api/MovieApi/");
        }
        public async Task<List<Movie>> GetAllMovies()
        {
            HttpResponseMessage theResponse = await _httpClient.GetAsync("movies");

            //Movie[] movies = await _httpClient.GetFromJsonAsync<Movie[]>("movies");

            string dataReturned = await theResponse.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<List<Movie>>(dataReturned);
        }

        public async Task<Movie> AddMovie(Movie newMovie)
        {
            string jsonForObject = JsonSerializer.Serialize(newMovie);

            StringContent theData = new StringContent(jsonForObject, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage thePostResponse = await _httpClient.PostAsync("movies/create", theData);

            String dataReturnedPost = await thePostResponse.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Movie>(dataReturnedPost);

        }

        public async Task<Movie> RemoveMovie(int id)
        {
            HttpResponseMessage theDeleteResponse = await _httpClient.DeleteAsync($"movies/delete/{id}");

            String dataReturnedPost = await theDeleteResponse.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Movie>(dataReturnedPost);

        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            string jsonForObject = JsonSerializer.Serialize(movie);

            StringContent theData = new StringContent(jsonForObject, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage thePutResponse = await _httpClient.PutAsync("movies/update", theData);

            String dataReturnedPut = await thePutResponse.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<Movie>(dataReturnedPut);
        }
    }
}
