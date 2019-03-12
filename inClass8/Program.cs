//This is my own work
//Noah Vandervelden
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inClass8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of grams of fat eaten");

            int fatCals = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the number of grams of carbs eaten");

            int carbCals = int.Parse(Console.ReadLine());

            fatCals = fatCalories(fatCals);
            carbCals = carbCalories(carbCals);

            Console.WriteLine("number of calories made up from fat: " + fatCals);
            Console.WriteLine("number of calories made up from carbs: " + carbCals);


        }

        static int fatCalories(int fatCals)
        {
            fatCals = fatCals * 9;
            return fatCals;
        }

        static int carbCalories(int carbCals)
        {
            carbCals = carbCals * 4;
            return carbCals;
        }
    }
}
