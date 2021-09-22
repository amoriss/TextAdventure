using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure2
{
    class SecondCourse
    {

        public bool userChoiceSecondCourse()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t \t Choose what you would like to serve for the 2nd course: ");
            Console.WriteLine("\t \t \t Select 1, 2, or 3");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t \t 1) Butter Poached Main Lobster with Spinach, Shittake and Leek Rice Noodles");
            Console.WriteLine("\t \t \t 2) Saddle of Spring Lamb with Vegetables");
            Console.WriteLine("\t \t \t 3) Herb Crusted Chicken with White Wine Butter Sauce");
            var input = Console.ReadLine();
            Console.Clear();
            switch (input.ToLower())
            {
                case "1":
                case "one":                    
                    return true;
                case "2":
                case "two":                  
                    return false;
                case "3":
                case "three":                 
                    return false;
                default:                   
                    return false;

            }

        }     


    }
}
