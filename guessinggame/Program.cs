using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            /** RUKKY's GUESSING GAME SOLUTION **/

            Console.Write("Enter Your Name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!!! Welcome Caesar's Guess the Number Game");
            
            Random rd = new Random(); 
            int selectedNum = rd.Next(1, 101); // 101 because the Next method excludes the upper bound

            // this is just another way of doing string concatenation like we did in line 15 above
            Console.WriteLine($"{name} I just selected a Random number between 1 and 100, guess the number I selected. You have 3 tries!!!");

            // the user will get a chance to try 3 times. 
            // Counting starts at 0
            // 0, 1, 2
            for(int i = 0; i < 3; i++){
                Console.WriteLine($"Trial number #{i + 1}:");
                int guessedNum = Convert.ToInt32(Console.ReadLine());

                if(guessedNum < 0 || guessedNum > 100){
                    Console.WriteLine($"{guessedNum} is not a valid guess between 1 and 100");
                } else if(guessedNum != selectedNum){
                    Console.WriteLine("You guessed wrong!!");
                }else if (guessedNum == selectedNum){
                    Console.WriteLine($"Congratulations {name}. YOU WON!!!!");
                    break;
                }
            }
                       
            
        }
        
    }
}
