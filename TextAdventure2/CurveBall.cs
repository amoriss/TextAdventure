using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure2
{
    public static class CurveBall
    {

        
    public static bool PickIngredient()
    {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            bool poison = true;
            Console.WriteLine("\t \t \t The Queen's Corgis got into the kitchen and ate all the carrots. \n");
            Console.WriteLine("\t \t \t Which would you like to replace the carrots with? \n" +
                "\t \t \t 1) Peas  2) Squash or 3) Tomatoes");
            var input = Console.ReadLine().ToLower();
            Console.Clear();
            if (input == "1" || input == "one" || input.ToLower() == "peas")
            {
                poison = true; 
            }
            /*
        if (input == "peas"|| input == "1")
        {
            poison = true;
        }
            */
            else
            {
                poison = false;
            }
            return poison;
       // }
        //return poison; 

    }
        public static bool AddaDrink()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t \t The President of India's wife has requested a martini before dinner starts.\n");
            Console.WriteLine("\t \t \t What type of martini would you like to serve?");
            Console.WriteLine("\t \t \t NOTE: She has an unknown allergy!");
            Console.WriteLine();
            Console.WriteLine("\t \t \t  1) apple 2) raspberry lemon 3) extra dirty ");
            var input = Console.ReadLine();
            Console.Clear();
            switch (input.ToLower())
            {
                case "1":
                case "apple":
                    return true;
                case "2":
                case "classic":
                    return false;
                case "3":
                case "extra dirty":
                    return false;
                default:
                    return false; 

            }
        }


        public static bool AssistantChefOut()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t \t \t Your Sous Chef is out sick at the very last minute. \n" +
                "\t \t \t You have less time to complete your meal.");
            Console.WriteLine();
            Console.WriteLine("\t \t \t What will you do? (These are your only options!) \n" +
                "\t \t \t 1) Ask for help from the Secret Service  \n" +
                "\t \t \t 2) Use an Instant Pot \n" +
                "\t \t \t 3) Order dessert from a local restaurant ");
            var input = Console.ReadLine();
            Console.Clear();
            switch (input.ToLower())
            {
                case "1":
                    return true;
                case "2":
                    return false;
                case "3":
                    return false;
                default:
                    return false; 

            }
        }
    

        }
    }
