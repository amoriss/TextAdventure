using System;
using System.Threading;
using TextAdventure2;

namespace TextAdventure2
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro.IntroScreen();
            //Call first course
            //Call Second Course
            //Call third course 

            var firstCourse = new FirstCourse();          
            
            bool firstAnswerisRight = firstCourse.UserChoiceFirstCourse();

            var curveBall1 = CurveBall.PickIngredient();  
            


            var secondCourse = new SecondCourse();
            bool secondAnswerisRight = secondCourse.userChoiceSecondCourse();

            var thirdCourse = new ThirdCourse();
            bool thirdAnswerisRight = thirdCourse.userChoiceThirdCourse();
            var curveBall2 = CurveBall.AddaDrink();

            var curveBall3 = CurveBall.AssistantChefOut();

            if (firstAnswerisRight && secondAnswerisRight && thirdAnswerisRight && !curveBall1 && !curveBall2 && !curveBall3)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t \t \t Congratulations! \n" +
                    "\t \t \t YOU ARE THE BEST CHEF IN THE WORLD ");
                
            }

            if (!firstAnswerisRight || !secondAnswerisRight || !thirdAnswerisRight)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t \t \t Unfortunately, the Queen doesn't like what you prepared.");
                Thread.Sleep(1000);
            }

            if (curveBall1 || curveBall2)
            {                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t \t \t Something you served caused food poisoning!");
                Thread.Sleep(500);
            }
            if (curveBall3)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("\t \t \t You ran out of time to cook the meal! \n" +
                    "\t \t \t The Secret Service were in over their head. \n" +
                    "\t \t \t The dignitaries are missing their dessert!");
                Thread.Sleep(500);                
                Console.WriteLine("\t \t \t They are pissed!");
            }
            if (curveBall1 || curveBall2 || curveBall3||!firstAnswerisRight || !secondAnswerisRight || !thirdAnswerisRight)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t \t \t You lost the game. Try again!");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t \t \t Play the game again!");
            }

            

         

            
        }
    }
}
