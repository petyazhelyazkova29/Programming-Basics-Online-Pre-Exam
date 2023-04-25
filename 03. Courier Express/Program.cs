using System;

namespace _03._Courier_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double shipmentKg = double.Parse(Console.ReadLine());
            string service = Console.ReadLine();
            int kilometers = int.Parse(Console.ReadLine());
            double pricePerKm = 0;
            double markup = 0;
            
            // standart
                if (shipmentKg<1)
                {
                    pricePerKm = 0.03;
                }
                else if (shipmentKg<10)
                {
                    pricePerKm = 0.05;
                }
                else if (shipmentKg<40)
                {
                    pricePerKm = 0.10;
                }
                else if (shipmentKg<90)
                {
                    pricePerKm = 0.15;
                }
                else if (shipmentKg<150)
                {
                    pricePerKm = 0.20;
                }
            if (service== "express")
            {
                if (shipmentKg < 1)
                {
                    markup = pricePerKm*0.80*kilometers*shipmentKg;
                }
                else if (shipmentKg < 10)
                {
                    markup += pricePerKm*0.40*kilometers* shipmentKg;
                }
                else if (shipmentKg < 40)
                {
                    markup += pricePerKm*0.05*shipmentKg*kilometers;
                }
                else if (shipmentKg < 90)
                {
                    markup += pricePerKm*0.02*kilometers* shipmentKg;
                }
                else if (shipmentKg < 150)
                {
                    markup += pricePerKm*0.01*kilometers* shipmentKg;
                }
            }
            double sum = kilometers * pricePerKm + markup;
            Console.WriteLine($"The delivery of your shipment with weight of {shipmentKg:f3} kg. would cost {sum:f2} lv.");
        }
    }
}
