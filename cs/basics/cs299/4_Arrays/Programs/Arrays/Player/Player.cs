/* Player.cs     Author:  Doyle
 * Creates class with characteristics
 * about one player. Includes name
 * and ID fields, plus points scored.
 * Any number of games can be used
 * to instantiate an object of this class.
 * Average calculated based on the
 * number of points associated with
 * one player.
 */
using System;
namespace PlayerApp
{
	public class Player
	{
		private string lname;
        private string fname;
        private string id;
        private int[ ] pointsScored;
        private int numberOfGames;
        private double avg;
        
        // Default Constructor
        public Player()
		{
		}
        
        // Constructor accepts any size
        // pointsScored array. 
        public Player (string ln, string fn,
                   string iden,  int [ ] s, int numGames)
        {
            numberOfGames = numGames;
            FillPointsScoredArray(s);
            ComputeAverage( );
            lname = ln;
            fname = fn;
            id = iden;
        }
     
        // Property returning calculated average

        public double Average
        {
            get 
            {
                return avg;
            }
        }
    
        public string FName
        {
            get 
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }
       
        public string LName
        {
            get 
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        
        public string ID
        {
            get 
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        
        public void FillPointsScoredArray(int [ ] s)
        { 
            pointsScored = new int [numberOfGames];
            for (int i = 0; i < pointsScored.Length; i++)
                pointsScored[i] = s[i];
        }
                    
        public void ComputeAverage( )
        {
            int total = 0; 

            foreach(int s in pointsScored)
                total += s;
            if(pointsScored.Length > 0)
               avg = total / pointsScored.Length;
        }
	}
}
