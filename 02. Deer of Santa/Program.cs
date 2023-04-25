using System;

namespace _02._Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int leftFood = int.Parse(Console.ReadLine());
            double deer1FoodPerDay = double.Parse(Console.ReadLine());
            double deer2FoodPerDay =  double.Parse(Console.ReadLine());
            double deer3FoodPerDay = double.Parse(Console.ReadLine());

            double eatenFood = deer1FoodPerDay * days + deer2FoodPerDay*days + deer3FoodPerDay * days;
            if (eatenFood<=leftFood)
            {
                Console.WriteLine($"{Math.Floor(leftFood-eatenFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(eatenFood-leftFood)} more kilos of food are needed.");
            }

        }
    }
}
