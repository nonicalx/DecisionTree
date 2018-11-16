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
            CSVReader(filePath);

        }
            public static List<string> CSVReader(string path)
            {
                List<string> result = new List<string>();
                string[] atributeArray = new string[result.Count];
                var atribute = new List<string>();
                var reader = new StreamReader(File.OpenRead(path));

                

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    result.Add(line);
                }
                for (int i = 0; i < result.Count; i++)
                {
                    string extract = result[i].ToString();
                    atributeArray = extract.Split(',');
                    atribute.Add(atributeArray[0]);
                }

                return atribute;
            }
    }
}