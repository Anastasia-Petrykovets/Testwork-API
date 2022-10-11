using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Testwork_API.Controllers
{
    internal class Service
    {
        static HttpClient client = new HttpClient();
        private const string URL = "http://tester.consimple.pro";
        static async Task<Models.ProductsAndCategoriesDTO> GetProductAndCategoriesAsync(string path)
        {
            string strResponse = "";
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                strResponse = await response.Content.ReadAsStringAsync();
            }
            return JsonConvert.DeserializeObject<Models.ProductsAndCategoriesDTO>(strResponse);
        }
        static public async Task RunAsync()
        {
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            try
            {
                Models.ProductsAndCategoriesDTO productAndCategories = new Models.ProductsAndCategoriesDTO();
                // Get the product
                var productsAndCategories = await GetProductAndCategoriesAsync(URL);
                Program.ShowTable(productsAndCategories);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
