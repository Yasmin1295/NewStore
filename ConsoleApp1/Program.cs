using Library;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store("Scandalo",300);

            Experience experience = new Experience(3, 12, 9);
            Seller seller = new Seller("Yasmin", 23, experience);

            Products pineapples = new Products("Pineapples", 5);
            Products bananas = new Products("Bananas", 2.3);
            Products strawberries = new Products("Strawberries", 3.4);

        }
    }
}
