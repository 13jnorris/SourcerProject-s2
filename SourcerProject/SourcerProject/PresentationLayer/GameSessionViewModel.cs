using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SourcerProject.Models;
using System.Collections.ObjectModel;

namespace SourcerProject.PresentationLayer
{
    public class GameSessionViewModel:ObservableObject
    {
        #region ENUMS



        #endregion

        #region FIELDS

        private Player _player;
        private List<string> _messages;
        private DateTime _gameStartTime;
        private Map _gameMap;
        private Location _currentLocation;
        private ObservableCollection<Location> _accessibleLocation;
        private string _currentLocationName;
        private List<string> _accessibleLocaction;

        public List<string> AccessibleLocation
        {
            get { return _accessibleLocaction; }
            set { _accessibleLocaction = value; }
        }


        public string CurrentLocationName
        {
            get { return _currentLocationName; }
            set { _currentLocationName = value; }
        }


        public ObservableCollection<Location> AcessibleLocation
        {
            get { return _accessibleLocation; }
            set { _accessibleLocation = value; }
        }


        public Location currentLocation
        {
            get { return _currentLocation; }
            set { _currentLocation = value; }
        }


        public Map gameMap
        {
            get { return _gameMap; }
            set { _gameMap = value; }
        }


        #endregion

        #region PROPERTIES

        public Player Player
        {
            get { return _player; }
            set { _player = value; }
        }

        public string MessageDisplay
        {
            get { return FormatMessagesForViewer(); }
        }

        #endregion

        #region CONSTRUCTORS

        public GameSessionViewModel()
        {

        }

        public GameSessionViewModel(
            Player player,
            List<string> initialMessages,
            Map gameMap,
            Location currentLocation)
        {
            _player = player;
            _messages = initialMessages;
            _gameMap = gameMap;
            _currentLocation = currentLocation;
            _accessibleLocation = _gameMap.AcessibleLocations;
            InitializeView();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// initial setup of the game session view
        /// </summary>
        private void InitializeView()
        {
            _gameStartTime = DateTime.Now;
        }

        /// <summary>
        /// generates a sting of mission messages with time stamp with most current first
        /// </summary>
        /// <returns>string of formated mission messages</returns>
        private string FormatMessagesForViewer()
        {
            List<string> lifoMessages = new List<string>();

            for (int index = 0; index < _messages.Count; index++)
            {
                lifoMessages.Add($" <T:{GameTime().ToString(@"hh\:mm\:ss")}> " + _messages[index]);
            }

            lifoMessages.Reverse();

            return string.Join("\n\n", lifoMessages);
        }

        /// <summary>
        /// running time of game
        /// </summary>
        /// <returns></returns>
        private TimeSpan GameTime()
        {
            return DateTime.Now - _gameStartTime;
        }

        private void OnPlayerMove()
        {
            Location newLocation = new Location();
            foreach (Location location in AcessibleLocation)
            {
                if(location.Name == _currentLocationName)
                {
                    newLocation = location;
                }
            }
        _gameMap.CurrentLocation = newLocation;
            _currentLocation = newLocation;

        }

        #endregion
    }
}
