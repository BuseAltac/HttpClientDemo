using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Brand
    {
        using var  = new HttpClient();
        client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", "YzRlNjA4NWVkYTgwMmU4M2MzNmI3NzczOTcyODlkZDVjZTg0NTQ0MGI2YTk4MjNhYjZkOWZkZDU4ZTE1NTlhNw");


        var content = client.GetStringAsync("https://senolozbek1.myideasoft.com/api/categories");
}
}
