using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace Session03Nubers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konvertera ett antal siffror i en array. 
            //Räkna ut det högsta värdet, vilket som är det lägsta värdet och medelvärdet (snitt på alla siffror i arrayen). 
            Console.WriteLine("Ange ett antal siffror separerat med kommatecken:");
            
            var input = Console.ReadLine();
            var inputArray = input.Split(",", StringSplitOptions.RemoveEmptyEntries);
            double?[] numberArray = new double?[inputArray.Length];
            int sum = 0;
            
           
            for (int i = 0; i < inputArray.Length; i++)
            {
                bool parsed = double.TryParse(inputArray[i], out double parsedValue);

                if (parsed == true) // (parsed) är samma sak som (parsed == true)
                {
                    numberArray[i] = parsedValue;
                }

                else
                {
                    numberArray[i] = null;
                }
                
            }
       
            foreach (int number in numberArray)
            {
                Console.WriteLine("Värde: " + number.ToString());
                
                
                
                sum += number;
                

            }
            Console.WriteLine("Det högsta värdet är: " + );
            Console.WriteLine("Det lägsta värdet är: " + );
            Console.WriteLine("Medelvärdet är: " + sum / numberArray.Length);
        }
    }
}
