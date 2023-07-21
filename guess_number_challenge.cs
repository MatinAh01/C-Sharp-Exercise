using System;

namespace guess_challenge_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var playAgain = true;
            var randomNumber = random.Next(1, 101);


            do
            {

                var guess = 0;
                var round = 0;

                while (guess != randomNumber)
                {
                    Console.WriteLine("guess a number please");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"your guess is : {guess} ");

                    if (guess > randomNumber)
                    {
                        Console.WriteLine($"{guess} is too high!!");
                    }
                    else if (guess < randomNumber)
                    {
                        Console.WriteLine($"{guess} is too low!!");
                    }
                    round++;


                }

                Console.WriteLine("you win!");
                Console.WriteLine($"round: {round}");
                Console.WriteLine("would you like play again?\n(yes, no)");
                var userRespound = Console.ReadLine();
                userRespound = userRespound.ToLower();
                playAgain = userRespound == "yes";

            } while (playAgain);


            Console.WriteLine("good luck!");
        }
    }
}
