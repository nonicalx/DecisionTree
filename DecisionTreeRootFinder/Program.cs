using System;
using System.Collections.Generic;
using System.IO;

namespace DecisionTreeRootFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var filePath = @"C:\Users\ORANYE-A.N\Desktop\sample.csv";
            Console.WriteLine("Hello World!");
            string[] content1 = new string[10];
            var atr1 = new List<string>();
            var reader = new StreamReader(File.OpenRead(filePath));

            List<string> result = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                result.Add(line);
            }
            for (int i = 0; i < result.Count; i++)
            {

                Console.WriteLine(result[i]);
                string extract = result[i].ToString();
                content1 = extract.Split(',');
                Console.WriteLine(content1[0]);
                atr1.Add(content1[0]);
                Console.WriteLine();
            }

            foreach (var item in atr1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
