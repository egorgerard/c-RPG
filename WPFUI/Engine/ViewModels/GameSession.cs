using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession
    {
        public Player CurrentPlayer { get; set; }

        public GameSession() {

            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Jin";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.Class_ = "Fighter";
            CurrentPlayer.Hit_points = 25;
            CurrentPlayer.Exp = 0;
            CurrentPlayer.Lvl = 1;
            
        }
    }
}
