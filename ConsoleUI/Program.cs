using Business.Concrete;
using System;


namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());

            Console.WriteLine("Hello World!");
        }
    }
}
