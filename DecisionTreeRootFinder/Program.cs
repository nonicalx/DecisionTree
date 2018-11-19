using System;
using System.Collections.Generic;
using System.IO;

namespace DecisionTreeRootFinder
{
    class Program
    {
        static List<string> result = new List<string>();
        static string filePath = @"C:\Users\ORANYE-A.N\Desktop\sample.csv";

        static void Main(string[] args)
        {
            ReadCSVFile();
            var output = GetAtribute(0);
            AttributeEntropyCalculator(output);
            DataSetEntropy();
            Console.ReadLine();
        }
        public static void ReadCSVFile()
        {
            var reader = new StreamReader(File.OpenRead(filePath));

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                result.Add(line);
            }
        }

        public static List<string> GetAtribute(int atributeIndex)
        {
            string[] atributeArray = new string[result.Count];
            Console.WriteLine(result.Count);
            var atribute = new List<string>();

            for (int i = 0; i < result.Count; i++)
            {
                string extract = result[i].ToString();
                atributeArray = extract.Split(',');
                atribute.Add(atributeArray[atributeIndex]);
            }

            return atribute;
            }
            
        public static  double AttributeEntropyCalculator(List<string> atribute)
        {
           double subsetEntropy = 0;
            
           return subsetEntropy;
        }

        public static double DataSetEntropy()
        {
            var outputList = GetAtribute(4);
            double dataSetEntroy = 0;
            GetOccurance(outputList);
            return dataSetEntroy;
        }

        public static void GetOccurance(List<string> atribute)
        {
            var uniqueElements = new List<string>();
            var numberOfOccurances = new List<int>();
            var eachAtribute = new HashSet<string>(atribute);

            foreach (var item in eachAtribute)
            {
                uniqueElements.Add(item);
                Console.WriteLine(item);
            }

            for (int i = 1; i < uniqueElements.Count; i++)
            {
                int occurance = 0;
                string keyword = uniqueElements[i];
                string atributeToString = "";
                for (int x = 0; x < atribute.Count; x++)
                {
                    atributeToString += atribute[x].ToString() + " ";
                }
                int index = atributeToString.IndexOf(keyword);
                while (index != -1)
                {
                    occurance += 1;
                    index = atributeToString.IndexOf(keyword, index + 1);
                }
                Console.WriteLine($"{keyword} occurs {occurance} times");
                numberOfOccurances.Add(occurance);
            }
        }
    }
}