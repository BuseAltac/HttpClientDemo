using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace HttpClientDemo
{
   public class Product
    {
        public async Task Product1()
        {

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",
                "ZWI0M2NiZmE2Mzc1ZmY5OTA1ZWQ3YjMwZjdkZjEwNjIzZWI5YWE3OTI5MzMwNjA3OWI4OWJkYjYzZTQyN2UwMA");



            var contentProduct = await client.GetStringAsync("https://senolozbek1.myideasoft.com/api/products");


            var jsoncontentproduct = JsonConvert.DeserializeObject(contentProduct);
            Console.WriteLine(JsonConvert.SerializeObject(jsoncontentproduct,Formatting.Indented));
        }
    }
}
