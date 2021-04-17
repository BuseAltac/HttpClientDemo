using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ConsoleApp1
{
    public class Product
    {
          using var client = new HttpClient();
          client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer" ,"YzRlNjA4NWVkYTgwMmU4M2MzNmI3NzczOTcyODlkZDVjZTg0NTQ0MGI2YTk4MjNhYjZkOWZkZDU4ZTE1NTlhNw");
    }
}
