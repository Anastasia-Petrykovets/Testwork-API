using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using ConsoleTables;


namespace Testwork_API
{
    class Program
    {
        static void Main()
        {
            Controllers.Service.RunAsync().GetAwaiter().GetResult();
        }
        static public void ShowTable(Models.ProductsAndCategoriesDTO productsAndCategories)
        {
            var query = productsAndCategories.Products.Join(productsAndCategories.Categories,
                                p => p.CategoryId,
                                c => c.Id,
                                (p, c) => (c.Name, c.Name));

            var table = new ConsoleTable("ProductName", "CategoryName");
            foreach (var item in query)
            {
                table.AddRow(item.Item1, item.Item2);
            }
            Console.WriteLine(table);
        }     
    }
}
