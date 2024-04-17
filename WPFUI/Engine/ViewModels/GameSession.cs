using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Factories;
using System.ComponentModel;

namespace Engine.ViewModels
{
    public class GameSession : BaseNotificationClass
    {
        private Location _currentLocation;
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation {
            get { return _currentLocation; }
            set {
                _currentLocation = value;
                OnPropertyChanged(nameof(CurrentLocation));

                // Können des hier rein klatschen weil die Location Property sich changed wenn die CurrentLocation sich changed ( no setter needed for isNorth und co. 
                OnPropertyChanged(nameof(isNorth));
                OnPropertyChanged(nameof(isWest));
                OnPropertyChanged(nameof(isEast));
                OnPropertyChanged(nameof(isSouth));

            }
        }

        public bool isNorth
        {

            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null; }
        }

        public bool isWest
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate -1, CurrentLocation.YCoordinate) != null; }
        }

        public bool isEast
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate +1, CurrentLocation.YCoordinate) != null; }
        }

        public bool isSouth
        {
            get { return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null; }
        }



        public GameSession() 
        {

            CurrentPlayer = new Player { 
                Name = "Jin", 
                Gold = 100, 
                Class_ = "Fighter", 
                Hit_points = 10, 
                Exp = 0, Lvl = 1 
            };

            CurrentWorld = WorldFactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);

        }

        public void MoveNorth()
        {
            if (isNorth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            }
        }

        public void MoveWest()
        {
            if(isWest)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            }
        }

        public void MoveEast()
        {
            if(isEast)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            }
        }
        public void MoveSouth()
        {
            if (isSouth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate -1);
            }
        }




}
}
