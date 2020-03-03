using System;

namespace RockPaperScissors
{
    class MainGame
    {
        static void Main(string[] args)
        {
            RockPaperScissorsGame game = new RockPaperScissorsGame();

            bool readyToQuit = false;
            
            while(!readyToQuit)
            {
                Console.WriteLine("Do you want to play a round? ");
                string input = Console.ReadLine();

                if (input.ToUpper() == "N")
                {
                    readyToQuit = true;
                }
                else
                {
                    game.PlayRound();
                    // play round, print result
                }
            }

            game.PrintSummary();
            // wins and loses
        }
    }
}
