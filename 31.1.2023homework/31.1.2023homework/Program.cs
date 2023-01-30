using System;

namespace _31._1._2023homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Drink dr = new Drink
            {
                Name = "GO",
                Price = 1.80,
                Alcoholpercent = 8


            };

            Console.WriteLine($"Name : {dr.Name} Price : {dr.Price} AlcoholPercent : {dr.Alcoholpercent}");







        }
    }
}
