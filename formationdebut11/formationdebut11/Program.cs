using System;

namespace formationdebut11
{
    class Program
    {
        static void Main(string[] args)
        {
            var robin = new Person();
            robin.FirstName = "Robin";
            robin.LastName = "Mahieu";
            robin.Introduce();

            Calculator calculator = new Calculator();
            var result = calculator.Add(1, 2);
            Console.WriteLine(result);
        }
    }
}
