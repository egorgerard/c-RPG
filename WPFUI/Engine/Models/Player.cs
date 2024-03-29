using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Models{
    public class Player : INotifyPropertyChanged {

        
        private string _name;
        private string _class;
        private int _hit_points;
        private int _exp;
        private int _lvl;
        private int _gold;

        // Man kann jetzt Quasi direkt sehen dass sich die Exp Beispielsweise geändert hat im UI direkt. 
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Class_
        {
            get { return _class; }
            set
            {
                _class = value;
                OnPropertyChanged("Class");
            }
        }

        public int Hit_points
        {
            get { return _hit_points; }
            set
            {
                _hit_points = value;
                OnPropertyChanged("Hit_points");
            }
        }

        public int Exp
        {
            get { return _exp; }
            set
            {
                _exp = value;
                OnPropertyChanged("Exp");
            }
        }
        public int Lvl
        {
            get { return _lvl; }
            set
            {
                _lvl = value;
                OnPropertyChanged("Lvl");
            }
        }

        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged("Gold");
            }
        }

        // If some1 listening to PropertyChanged Event Handler we need to send a Msg that this porperty has changed 
        // Quasi UI abboniert da und sieht wenn sich was ändert.
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
