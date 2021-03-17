using System;
using System.IO;
using Microsoft.VisualBasic;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayManaged array = new ArrayManaged();

            string[] file = File.ReadAllLines(Environment.CurrentDirectory + "\\file.txt");

            foreach (var line in file)
            {
                string temporal ="";
                foreach(char character in line)
                {
                    if(Information.IsNumeric(character))
                    {
                        temporal += character;
                    }
                }
                if(temporal != "")
                {
                    try
                    {
                        array.Add(Convert.ToInt64(temporal));
                    }
                    catch (Exception)
                    {
                        Console.Write("");
                    }
                                    
                    //Console.WriteLine(array); 
                }
                
            }
            ArrayManaged.PrintArray(array);
            Console.WriteLine($"\n\nMax value: {array.Max}");
            Console.WriteLine($"Min value: {array.Min}");
            Console.WriteLine($"Average: {array.Average}");

        }
    }
}
