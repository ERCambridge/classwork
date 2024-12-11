using moviesAPI.Models;
using System.Text.Json;

namespace CallAPIsConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //This code will make Http REST requests to our Movies API Server
            HttpClient theClient = new HttpClient();
            theClient.BaseAddress =  new Uri("https://localhost:7010/api/MovieAPI/");

            HttpResponseMessage theResponse = await theClient.GetAsync("Movies");
            if (theResponse.IsSuccessStatusCode)
            {
                string dataReturned = await theResponse.Content.ReadAsStringAsync();    
                Console.WriteLine(dataReturned);
                List<Movie> theMovies = JsonSerializer.Deserialize<List<Movie>>(dataReturned);
                foreach(Movie aMovie in theMovies)
                {
                    Console.WriteLine(aMovie.Title);
                }
            }
            else
            {
                Console.WriteLine($"Error in API call: {theResponse.StatusCode}");
            }

            Movie newMovie = new Movie();
            newMovie.Title = "Jurassic Park";
            newMovie.ReleaseYear = 1993;
            newMovie.Director = "Steven Spielberg";

            string jsonForObject = JsonSerializer.Serialize(newMovie);
            
            StringContent content = new StringContent(jsonForObject, System.Text.Encoding.UTF8, "application/json");

            HttpResponseMessage thePostResponse = await theClient.PostAsync("Movies/Create", content);
        }   
    }
}
