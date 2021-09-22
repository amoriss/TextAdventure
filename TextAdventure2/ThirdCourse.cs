using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure2
{
    class ThirdCourse
    {

        public bool userChoiceThirdCourse()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t \t Choose what you would like to serve for the 3rd course: ");
            Console.WriteLine("\t \t \t Select 1, 2, or 3");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t \t 1) Holy Basil-Pear Sorbet with Honey Yogurt Whip and Pistachio Oat Streusel");
            Console.WriteLine("\t \t \t 2) Milk Chocolate Pudding, Coconut Yogurt, Sunflower Seed Coffee Crumble");
            Console.WriteLine("\t \t \t 3) Maple Pecan Cake with Cocoa Nib Wafer, Butterscotch Swirl Ice Cream");
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
