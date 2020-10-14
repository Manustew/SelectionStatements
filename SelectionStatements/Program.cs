using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1:  if, else if
            int favNumber = 1698;
            Console.Write("Guess my favorite number");
            int guess = int.Parse(Console.ReadLine());
            
            if (guess < favNumber)
            {
                Console.WriteLine("Your guess is too low");
            }
            else if (guess > favNumber)
            {
                Console.WriteLine("Your guess is too high");
            }
            else if (guess == favNumber)
            {
                Console.WriteLine("You got it!");
            }
            //Part 2:  Switch Case

            

            Console.WriteLine("What is your favorite school subject?");
            string userSubject = Console.ReadLine();

            switch (userSubject)
            {
                case "Geography":
                    Console.WriteLine("You are in the right class!");
                    break;
                case "Math":
                    Console.WriteLine($"This is not {userSubject} class");
                    break;
                case "Science":
                    Console.WriteLine($"Does this look like a {userSubject} class to you!?!?");
                    break;
                default:
                    Console.WriteLine("That is a truly stupid answer");
                    break;
            }
            Console.WriteLine("I bet I can guess your drink of choice.  Just tell me what you do for a living");
            string favDrink = Console.ReadLine();

            switch (favDrink)
            {
                case "Jabroni":
                    Console.WriteLine("Patron Tequila");
                    break;
                case "Assistant Principal":
                    Console.WriteLine("Anything with ALCOHOL!!!");
                    break;
                case "Programmer":
                    Console.WriteLine("Hipster Craft Beer");
                    break;
                case "Bike Gang Member":
                    Console.WriteLine("Moonshine");
                    break;
                case "Politician":
                    Console.WriteLine("Your tax dollars");
                    break;
                case "rapper":
                    Console.WriteLine("Cristal");
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }

 
        }


    }



}
   
