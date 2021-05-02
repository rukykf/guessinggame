using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!!! Welcome Caesar's Guess the Number Game");
            
            int[] selectednum = new int[] { 60, 45, 33, 43, 56, 67, 54, 23, 89, 5, 7, 9 };
           
            
            Console.WriteLine("I just selected a number between 1 and 100, guess the number I selected");

            int numguessed = Convert.ToInt32(Console.ReadLine());
                      
                while (numguessed != selectednum[0] || numguessed != selectednum[1] || numguessed != selectednum[2] || numguessed != selectednum[3] || numguessed != selectednum[4] && numguessed >= 1 && numguessed <= 100) 
                {               
                    Console.WriteLine("try again");
                    int numguessed1 = Convert.ToInt32(Console.ReadLine());                   
                    numguessed = numguessed1;
                if (numguessed == selectednum[0] || numguessed == selectednum[1] || numguessed == selectednum[2] || numguessed == selectednum[3] || numguessed == selectednum[4])
                {
                    Console.WriteLine(name + " You Won!!! You guessed the number");
                    break;
                }              
                    
                }                               
            
        }
        
    }
}
