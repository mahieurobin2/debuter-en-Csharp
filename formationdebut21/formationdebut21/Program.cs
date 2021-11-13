using System;

namespace formationdebut21
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Robin Mahieu";

           // for (var i = 0; i < name.Length; i++)
           // {
           //    Console.WriteLine(name[i]);
           // }

            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
        }
    }
}
