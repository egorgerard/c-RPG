using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Engine.Models{
    public class Player : BaseNotificationClass {

        
        private string _name;
        private string _class;
        private int _hit_points;
        private int _exp;
        private int _lvl;
        private int _gold;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public string Class_
        {
            get { return _class; }
            set
            {
                _class = value;
                OnPropertyChanged(nameof(Class_));
            }
        }

        public int Hit_points
        {
            get { return _hit_points; }
            set
            {
                _hit_points = value;
                OnPropertyChanged(nameof(Hit_points));
            }
        }

        public int Exp
        {
            get { return _exp; }
            set
            {
                _exp = value;
                OnPropertyChanged(nameof(Exp));
            }
        }
        public int Lvl
        {
            get { return _lvl; }
            set
            {
                _lvl = value;
                OnPropertyChanged(nameof(Lvl));
            }
        }

        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = value;
                OnPropertyChanged(nameof(Gold));
            }
        }

        public ObservableCollection<GameItem> Inventory { get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();
        }


    }
}
