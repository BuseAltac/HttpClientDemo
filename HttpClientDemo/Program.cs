using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace HttpClientDemo
{
    class Program
    {


        static async Task Main(string[] args)
        {          

            Product product = new Product();
            await product.Product1();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            

            Category category = new Category();
            await category.Category1();

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("--------------------------------------------------------------------------");
           
           
            Brand brand = new Brand();
            await brand.Brand1();        

        }   
    }
}
