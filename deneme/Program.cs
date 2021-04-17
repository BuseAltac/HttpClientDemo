using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {
        
            static async Task Main(string[] args)
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "MWFmNDMxMGQxZGYxMjlhZDM5ZTA1OGFlZDVlYWUyZDRlZjhmMDA3YzJjZDljY2MzMGYwZGJlYzgzZmJmYzEwNg");


                
                var contentProduct = await client.GetStringAsync("https://senolozbek1.myideasoft.com/api/products");

                Console.WriteLine(contentProduct);

                
                
                Console.WriteLine("\n******\n");



                var contentCategory = await client.GetStringAsync("https://senolozbek1.myideasoft.com/api/categories");

                Console.WriteLine(contentCategory);




                Console.WriteLine("\n******\n");



                var contentBrand = await client.GetStringAsync("https://senolozbek1.myideasoft.com/api/brands");
   
                Console.WriteLine(contentBrand);




            static async Task Main(string[] args)
            {
                using var client = new HttpClient();
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "YzRlNjA4NWVkYTgwMmU4M2MzNmI3NzczOTcyODlkZDVjZTg0NTQ0MGI2YTk4MjNhYjZkOWZkZDU4ZTE1NTlhNw");


                var contentProduct = await client.GetStringAsync("https://senolozbek1.myideasoft.com/api/products");

                Console.WriteLine(contentProduct);

            }
        }
}
