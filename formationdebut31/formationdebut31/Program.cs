using System;
using System.Collections.Generic;

namespace formationdebut31
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really really really long text.";
            var summary = StringUtility.SummerizeText(sentence);
            Console.WriteLine(summary);
        }
    }
}
