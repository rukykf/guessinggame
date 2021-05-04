using System;

namespace guessinggame
{
    class Program
    {
        static void Main(string[] args)
        {
            /** FEEDBACK FOR SARAH **/

            Console.Write("Enter Name: ");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name + "!!! Welcome Caesar's Guess the Number Game");
            
            // Feedback 1: Here, you're not actually selecting the number at random.
            // There's a tutorial at this link on how to generate random numbers with C#: 
            // https://www.tutorialspoint.com/Random-Numbers-in-Chash
            // Read that tutorial and use the info you learned to fix this.
            int[] selectednum = new int[] { 60, 45, 33, 43, 56, 67, 54, 23, 89, 5, 7, 9 };
           
            
            Console.WriteLine("I just selected a number between 1 and 100, guess the number I selected");

            int numguessed = Convert.ToInt32(Console.ReadLine());
            
            /** 
             Feedback 2: Your indentation here is bad. This affects the legibility of code and makes it much harder
             to read and understand what is going on with the code. The While loop should be starting at the same indentation
             as the int numguessed = .... line above
             Also, the if statement in the while loop, I can't easily tell where it starts and where it stops because
             of the poor indentiation. Your code should look something like this

          
            while(numguessed != selectednum)
            {
                // some code here...
                if(something == something)
                {
                    // notice how it's easier to tell where the if statement starts and stops
                    // because of the proper indentation
                    // another code here with proper indentation
                }
            }
            **/

                while (numguessed != selectednum[0] || numguessed != selectednum[1] || numguessed != selectednum[2] || numguessed != selectednum[3] || numguessed != selectednum[4] && numguessed >= 1 && numguessed <= 100) 
                {               
                    Console.WriteLine("try again");
                    int numguessed1 = Convert.ToInt32(Console.ReadLine());                   
                    numguessed = numguessed1;

                // Feedback 3: This is related to the first feedback, you're using an array of possible answers here, which is okay
                // but, the answers should be generated randomly... not chosen by you.
                // that will make it harder to guess the correct number when you're testing the application but I want you to get a feel for random number generation
                // And, there's a neater way to check if something is in an array:
                // you could do this:
                // if selectednum.Contains(numguessed){...}


                // Feedback 4: I want different outputs for wrong answer vs. invalid answer.
                // right now, the program just tells me to 'try again' whether my answer is wrong or invalid

                // An invalid answer would be me entering something like -4 or 200... these numbers are not within the range
                // of 1 and 100 so I'd want an output that tells me that my input is invalid and that I should try again

                // A wrong answer would a number that is within the range 1 to 100... like 18, but it's just not the number
                // that the program guessed, so the program should output something that while my input is valid (between 1 and 100),
                // it's not the correct number
                if (numguessed == selectednum[0] || numguessed == selectednum[1] || numguessed == selectednum[2] || numguessed == selectednum[3] || numguessed == selectednum[4])
                {
                    Console.WriteLine(name + " You Won!!! You guessed the number");
                    break;
                }              
                    
                }                               
            
        }
        
    }
}
