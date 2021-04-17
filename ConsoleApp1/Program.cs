using System;
using System.Net.Http;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program 
    {
        static void Main(string[] args)
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "YzRlNjA4NWVkYTgwMmU4M2MzNmI3NzczOTcyODlkZDVjZTg0NTQ0MGI2YTk4MjNhYjZkOWZkZDU4ZTE1NTlhNw");


            var content =  client.GetStringAsync("https://senolozbek1.myideasoft.com/api/categories");

            Console.WriteLine(content);
            
            
        }
    }
}
