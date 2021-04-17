using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    class Category
    {
        public async Task Category1()

        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer",
                "ZWI0M2NiZmE2Mzc1ZmY5OTA1ZWQ3YjMwZjdkZjEwNjIzZWI5YWE3OTI5MzMwNjA3OWI4OWJkYjYzZTQyN2UwMA");


            var contentCategory = await client.GetStringAsync("https://senolozbek1.myideasoft.com/api/categories");


            var jsoncontentcategory = JsonConvert.DeserializeObject(contentCategory);
            Console.WriteLine(JsonConvert.SerializeObject(jsoncontentcategory, Formatting.Indented));
        }
    }
}
