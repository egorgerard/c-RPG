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
    public class GameSession : INotifyPropertyChanged
    {
        private Location _currentLocation;
        public World CurrentWorld { get; set; }
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation {
            get { return _currentLocation; }
            set {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");

                // Können des hier rein klatschen weil die Location Property sich changed wenn die CurrentLocation sich changed ( no setter needed for isNorth und co. 
                OnPropertyChanged("isNorth");
                OnPropertyChanged("isWest");
                OnPropertyChanged("isEast");
                OnPropertyChanged("isSouth");

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

            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Jin";
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.Class_ = "Fighter";
            CurrentPlayer.Hit_points = 25;
            CurrentPlayer.Exp = 0;
            CurrentPlayer.Lvl = 1;

            WorldFactory factory = new WorldFactory();
            CurrentWorld = factory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);

        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate +1);
        }

        public void MoveWest()
        {

            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate -1, CurrentLocation.YCoordinate);
        }

        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate +1, CurrentLocation.YCoordinate);
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate -1);
        }



        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
}
}
