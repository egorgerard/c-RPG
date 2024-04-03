using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();

        internal void AddLocation(int xCoordiante, int yCoordinate, string name, string description, string imageName)
        {
            Location loc = new Location();
            loc.XCoordinate = xCoordiante;
            loc.YCoordinate = yCoordinate;
            loc.Name = name;
            loc.Description = description;
            loc.ImageName = imageName;
            
            _locations.Add(loc);
        }

        public Location LocationAt(int xCoordiante, int yCoordinate)
        {
            // Good Way 
            foreach (Location loc in _locations)
            {
                if(loc.XCoordinate == xCoordiante && loc.YCoordinate == yCoordinate) 
                    return loc;
            }

            return null;


             /* Bad Way : 
             * 
             int locationSize = _locations.Count;

             for(int i = 0; i < locationSize; i++)
             {
                if(_locations[i].XCoordinate == xCoordiante && _locations[i].YCoordinate == yCoordinate)
                    return _locations[i];
          
             }
             return null;
             */

        }
    }
}
