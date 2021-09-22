using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure2
{
    public class FirstCourse
    {
     
        public bool UserChoiceFirstCourse()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t \t Choose what you would like to serve for the 1st course: ");
            Console.WriteLine("\t \t \t Select 1, 2, or 3");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t \t 1) Carrot Ginger Soup with Chili Butter and Roasted Peanuts");
            Console.WriteLine("\t \t \t 2) Beet, Rhubarb, and Carrot Salad");
            Console.WriteLine("\t \t \t 3) Cow and Gate Creamed Carrot and Potato");
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

        /* public void TurnColorGreen()
         {
             Console.ForegroundColor = ConsoleColor.Green;

         }
        */

        


    }

