using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace PlayerStats
{
    class Player{

        private float highScore;
        private int playedGames;
        private int wonGames;
   
        public float HighScore{
            get 
            { 
                return highScore;
            }
            set
            {
                if (highScore < value){
                    highScore = value;
                }           
            }
        }
        public string Name{get;}

        public float WinRate{
            get
            {
                return WinRate;
            }set{
                if (playedGames == 0)
                {
                    return;
                }else{
                    WinRate = wonGames/playedGames;
                }
            }
        }

        public void PlayGame(bool win){
            playedGames += 1;
            if (win){
                wonGames += 1;
            }
        }
        public Player(string name){
            Name = name;
            highScore = 0;
            playedGames = 0;
            wonGames = 0;

        }   
    }
    
    
}