using System;

namespace formationdebut25
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            const int passwordLength = 10;
            var buffer = new char[passwordLength]; 
            for (var i = 0; i < passwordLength; i++)
                buffer[i] = (char)('a'+ random.Next(0, 26));

            var password = new string(buffer);
            Console.WriteLine();

            Console.WriteLine((int)'a');  // a correspond a 97 dans la table ASCII ce qui fait que quand on va compiler la console va nous ressortir le nombre 97
        }
    }
}
