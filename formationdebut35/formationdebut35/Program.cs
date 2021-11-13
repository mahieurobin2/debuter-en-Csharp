using System;
using System.IO;

namespace formationdebut35
{
    class Program
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            // var files = Directory.GetFiles(@"c:\project\CSharpFundamentals", "*.sln*", SearchOption.AllDirectories);
            // foreach (var file in files)
            //     Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\projects\CSharpFundamentals", "*.*",
                    SearchOption.AllDirectories);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
        }
    }
}
