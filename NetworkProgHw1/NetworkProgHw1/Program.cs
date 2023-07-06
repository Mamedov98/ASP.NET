
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

class Program

{
    static async Task Main(string[] args)
    {


        using (HttpClient client = new HttpClient())
        {

            try
            {
                HttpResponseMessage response = await client.GetAsync("https://catfact.ninja/fact");
                if (response.IsSuccessStatusCode) 
                {
                  string  ResponseForApi = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(ResponseForApi);
                }
                else
                { Console.WriteLine("Error",response.StatusCode); }
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
