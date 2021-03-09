using System;

namespace triviaGame
{
    class Program
    {
        public static int[] testQuestions = new int[4];
        public static int[] testAnswers = new int[4];
        public static int[] studentAnswer = new int[4];

        static void Main(string[] args) 
        {
            Game();
            Console.WriteLine("Guess a number!");
            bool win = false;
            do
            {
                //Console.WriteLine("Guess a numeber."); put none repeating statements outside the scope of the loop
                var guess = int.Parse(Console.ReadLine());
                int answer = (69);

                if (guess < answer)
                {
                    Console.WriteLine("Try going up some.");
                }
                else if (guess > answer)
                {
                    Console.WriteLine("Bring it down a bit.");
                }
                else
                {
                    Console.WriteLine("Bingo!!");
                    win = true;
                }
                

            } while (win == false);
            Console.WriteLine("Now guess a color!");
            bool win2 = false;
            do
            {

                //Console.WriteLine("Now guess a color!");  Will repeat inside of the loop 

                var guess2 = Console.ReadLine();
                string answer2 = "blue";
                if (guess2 != answer2)
                {
                    Console.WriteLine("Try again!!");
                }
                else
                {
                    Console.WriteLine("You got it!!");
                    win2 = true;
                }


            } while (win2 == false);
            static void Seasons()
            {
                Console.WriteLine("Now what do you think my favorite season is?");

                bool win3 = false;
                do
                {
                
                    var Seasons = Console.ReadLine();

                    switch (Seasons)
                    {
                        case "spring":
                            Console.WriteLine("You Nailed it! I love spring!");
                            win3 = true;
                            break;
                        case "summer":
                            Console.WriteLine("A little too hot, try a bit cooler.");
                            break;
                        case "fall":
                            Console.WriteLine("Yes!! I absolutely love fall!");
                            win3 = true;
                            break;
                        case "winter":
                            Console.WriteLine("Winter is nice but way too cold, try something warmer.");
                            break;
                        default:
                            Console.WriteLine("I didnt quite catch that, try again.");
                             break;
                    }
                } while (win3 == false);
            }
            Console.WriteLine("Black, White, Red?");
            //bool win4 == false;
            //do
            //{

            //}while()

            static void Game()
            {
                Console.WriteLine("Would you like to play a little guessing game?");
                var answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Hell Yeah!! Lets do it!!!");
                    Seasons(); // Called when the answer is "yes"
                }
                else if (answer == "no")
                {
                    Console.WriteLine("Well fine then.");
              
                    //.exit();
                }
            }

        }
    }
}
