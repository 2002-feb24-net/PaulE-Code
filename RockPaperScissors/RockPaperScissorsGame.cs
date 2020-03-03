using System;
using System.Collections.Generic;

namespace RockPaperScissors
{
    class RockPaperScissorsGame
    {
        List<char> WLRecord = new List<char> {};
        char user;
        char computer;

        public void PlayRound()
        {
            this.user = getInput(); 
            this.computer = randomChoice();
            ResolveGame(user, computer);
        }
        public char getInput()
        {
            Console.WriteLine("CHOOSE: ROCK PAPER SCISSORS ");
            return (Convert.ToChar(Console.ReadLine().ToUpper()[0]));
        }

        public char randomChoice()
        {
            Random rnd = new Random();
            int x = rnd.Next(1,3);
            switch (x)
            {
                case 1:
                {
                    return 'R';
                }
                case 2:
                {
                    return 'P';
                }
                case 3:
                {
                    return 'S';
                }
            }
            return '?';
        }

        public void ResolveGame(char x, char y)
        {
            Console.WriteLine("You chose: {0}. The Computer chose: {1}", x,y);
            Console.WriteLine("{0} vs {1}",x,y);

            if ( x == y)
            {
                Console.WriteLine("TIE!");
                WLRecord.Add('T');
            }
            else if (x == 'R' && y == 'S')
            {
                Console.WriteLine("You win!");
                WLRecord.Add('W');
            }
            else if (x == 'R' && y == 'P')
            {
                Console.WriteLine("You lose..");
                WLRecord.Add('L');
            }
            else if (x == 'S' && y == 'P')
            {
                Console.WriteLine("You win!");
                WLRecord.Add('W');
            }
            else if (x == 'S' && y == 'R')
            {
                Console.WriteLine("You lose..");
                WLRecord.Add('L');
            }
            else if (x == 'P' && y == 'R')
            {
                Console.WriteLine("You win!");
                WLRecord.Add('W');
            }
            else if (x == 'P' && y == 'S')
            {
                Console.WriteLine("You lose..");
                WLRecord.Add('L');
            }
            else
            {
                Console.WriteLine("...did you even pick rock/paper/scissors?");
            }
        }

        public void PrintSummary()
        {
            int numL=0, numW=0, numT=0;
            foreach(char x in WLRecord)
            {
                if (x == 'L')
                {
                    numL++;
                }
                else if (x == 'W')
                {
                    numW++;
                }
                else if (x == 'T')
                {
                    numT++;
                }
                Console.Write(x+",");
            }
            Console.WriteLine();
            Console.WriteLine("Wins: {0} Losses: {1} Ties: {2}", numW,numL,numT);
        }
    }
}
