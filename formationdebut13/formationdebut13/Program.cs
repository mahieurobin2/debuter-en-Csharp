using System;

namespace formationdebut13
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Robin";
            var lastName = "Mahieu";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Jhon", "Jack", "Mary" };
            var formattedNames = string.Join(",", names);

            var text = @"Hi Jhon
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text);
        }
    }
}
