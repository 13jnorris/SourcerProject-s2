using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SourcerProject.Models
{
    public class Map
    {
        private ObservableCollection<Location> _locations;
        private Location _currentLocation;
    


        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }


        public ObservableCollection<Location> Locations
        {
            get { return _locations; }
            set { _locations = value; }
        }

        public ObservableCollection<Location> AcessibleLocations
        {
            get
            {
                ObservableCollection<Location> AccessibleLocations = new ObservableCollection<Location>();
                foreach (var location in _locations)
                {
                    if(location.Accessilbe == true)
                    {
                        AcessibleLocations.Add(location);
                    }
                }
                return AcessibleLocations;
            }
        }

        public void Move(Location location)
        {
            
            _currentLocation = location;
        }

    }
}
