using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    class Brand
    {
        public async Task Brand1()
        {
            using var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",
                "ZWI0M2NiZmE2Mzc1ZmY5OTA1ZWQ3YjMwZjdkZjEwNjIzZWI5YWE3OTI5MzMwNjA3OWI4OWJkYjYzZTQyN2UwMA");


            var contentBrand = await client.GetStringAsync("https://senolozbek1.myideasoft.com/api/brands");


            var jsonContentBrand = JsonConvert.DeserializeObject(contentBrand);
            Console.WriteLine(JsonConvert.SerializeObject(jsonContentBrand, Formatting.Indented));
        }

    }
}
