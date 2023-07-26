using System;

namespace rock_paper_scissors
{
    class Program
    {
        static void Main(string[] args)
        {
            var playAgain = true;

            while (playAgain)
            {
                var userInput = UserInput();
                var systemInput = Random();
                switch (userInput)
                {
                    case "ROCK":
                        if (systemInput == 1)
                        {
                            Console.WriteLine("you draw!");
                        }
                        else if (systemInput == 2)
                        {
                            Console.WriteLine("ooops you lose!!");
                        }
                        else if (systemInput == 3)
                        {
                            Console.WriteLine("graet you winnn!");
                        }
                        break;
                    case "PAPER":
                        if (systemInput == 1)
                        {
                            Console.WriteLine("graet you winnn!");
                        }
                        else if (systemInput == 2)
                        {
                            Console.WriteLine("you draw!");
                        }
                        else if (systemInput == 3)
                        {
                            Console.WriteLine("ooops you lose!!");
                        }
                        break;
                    case "SCISOORS":
                        if (systemInput == 1)
                        {
                            Console.WriteLine("ooops you lose!!");
                        }
                        else if (systemInput == 2)
                        {
                            Console.WriteLine("graet you winnn!");
                        }
                        else if (systemInput == 3)
                        {
                            Console.WriteLine("you draw!");
                        }
                        break;
                }
                Console.WriteLine("Thanks for playing!\nDo you want play again(Y/N)");
                var userRespound = Console.ReadLine();
                userRespound = userRespound.ToUpper();
                playAgain = userRespound == "Y";
            }
            Console.WriteLine("Have a good time!");
        }
        static string UserInput()
        {
            Console.Write("Enter ROCK, PAPER or SCISOORS: ");
            var input = Console.ReadLine();
            input = input.ToUpper();
            Console.WriteLine($"player: {input}");
            return input;
        }
        static int Random()
        {
            Random random = new Random();
            var randomNumber = random.Next(1, 4);
            if (randomNumber == 1)
            {
                Console.WriteLine("Computer: ROCK");
            }
            else if (randomNumber == 2)
            {
                Console.WriteLine("Computer: PAPER");
            }
            else if (randomNumber == 3)
            {
                Console.WriteLine("Computer: SCISSORS");
            }
            return randomNumber;
        }
    }
}
