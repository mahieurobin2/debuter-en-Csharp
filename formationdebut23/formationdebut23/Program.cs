using System;

namespace formationdebut23
{
    class Program
    {
        static void Main(string[] args)
        {
            //  for (var i = 1; i <= 10; i++)
            //  {
            //      if (i % 2 == 0)
            //          Console.WriteLine(i);
            //  }

            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
                i++;
            }
        }
    }
}
