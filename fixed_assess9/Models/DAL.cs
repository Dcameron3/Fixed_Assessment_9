using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;


namespace fixed_assess9.Models
{
    public class DAL
    {
        private static HttpClient client = null;
        private static HttpClient GetHttpClient()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("https://anapioficeandfire.com/");
            }
            return client;
        }
       public static async Task<Character> GetSpecificCharacter(int id)
        {
            var connection = await GetHttpClient().GetAsync($"/api/characters/{id}");
            Character resp = await connection.Content.ReadAsAsync<Character>();
            return resp;

        }
    }
}
