using System;

namespace formationdebut18
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isGoldCustomer = true;

            // float price;
            // if (isGoldCustomer)
            //     price = 19.95f;
            //else
            //     price = 29.95f;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine(price);
        }
    }
}
