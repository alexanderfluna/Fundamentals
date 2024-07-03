/*PlayerApp.cs     Author: Doyle
 * Application that instantiates
 * Player class. Creates an array
 * of player objects that can be
 * used to display individual 
 * records or do stats
 * on the entire team.
 */

using System;
namespace PlayerApp
{
    class PlayerApp
    {
        static void Main()
        {
            string ln,
                   fn,
                   iden;
            string inValue;

            int playerCnt,
                loopCnt = 0,
                gameCnt; 
            int [ ] points = new int [1000];
            
            Console.Write("How many players? ");
            inValue = Console.ReadLine( );
            playerCnt = Convert.ToInt32(inValue);

            Player[ ] teamMember = new Player[playerCnt];
            while(loopCnt < playerCnt)
            {
                GetIdInfo(out ln, out fn, out iden);
                gameCnt = 0; 
                points = GetScores(ref gameCnt);
                teamMember[loopCnt] = new Player(ln, fn, iden, points, gameCnt);
                loopCnt++;
            }
            DisplayStats(teamMember);
        }

        
        public static int [ ] GetScores(ref int gameCnt)
        {
            int [ ] points = new int [1000];
            string inValue;

            Console.Write("Game {0}: " 
                + "((-99 to exit)) ", 
                     gameCnt + 1);
            inValue = Console.ReadLine( );
       
            while(inValue != "-99")
            {
                points[gameCnt] = Convert.ToInt32(inValue);
                ++gameCnt;
                Console.Write("Game {0}: " 
                    + "((-99 to exit)) ", 
                         gameCnt + 1);
                inValue = Console.ReadLine( );
            }
           return points;
        }

        public static void GetIdInfo(out string ln, 
                             out string fn, out string iden)
        {   
             Console.WriteLine( );
             Console.Write("Player First Name: ");
             fn = Console.ReadLine( );
             Console.Write("Player Last Name: ");
             ln = Console.ReadLine( );
             Console.Write("Player ID Number: ");
             iden = Console.ReadLine( );
        }

        public static void DisplayStats(Player[] teamMember)
        {
            Console.WriteLine();
            Console.WriteLine("Player\t\tAvg Points ");
            Console.WriteLine("----------------------------");
            foreach(Player pl in teamMember)
            {

                Console.Write("{0} {1}\t", pl.FName, pl.LName);
                Console.WriteLine("{0}", pl.Average);
            }
        }
    }
}
