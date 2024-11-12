using System;
using System.Net.Http;  // this is for Http request by client
using System.Threading.Tasks;  // for async operation
using System.Net.Http.Json;  // For ReadFromJsonAsync

// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
public class DataClass
{
    public string type { get; set; }
    public string setup { get; set; }
    public string punchline { get; set; }
    public int id { get; set; }

    // Override ToString() method for better output
     
}

public static class FetchingData
{
    private static readonly HttpClient client = new HttpClient();  // Using this we can perform CRUD 

    public static async Task Main(string[] args)
    {
        string url = "https://official-joke-api.appspot.com/random_joke";  // URL for fetching joke data
        int n=5;
        while (n!=0)
        {
            n--;
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();  // Ensures the response has no errors

                var data = await response.Content.ReadFromJsonAsync<DataClass>();  // Deserialize the JSON response

                if (data != null)
                {
                    Console.WriteLine(data);  // Print the data using the overridden ToString method
                    Console.WriteLine("Id: "+ data.id);
                    Console.WriteLine("Type: "+ data.type);
                    Console.WriteLine("Setup: "+ data.setup);
                    Console.WriteLine("PunchLine: "+ data.punchline);
                    
                    
                }
                else
                {
                    Console.WriteLine("No data received.");
                }

                // Adding a small delay to prevent spamming the API with requests
                await Task.Delay(2000);
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request error: {ex.Message}");
            }
        }
    }
}
