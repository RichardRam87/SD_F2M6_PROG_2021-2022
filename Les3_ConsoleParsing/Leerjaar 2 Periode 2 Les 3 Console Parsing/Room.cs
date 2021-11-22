using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leerjaar_2_Periode_2_Les_3_Console_Parsing
{
    class Room
    {
        //a list of destinations
        public List<Room> destinations { get; private set; }

        //The story of the room
        public string story { get; private set; }

        //the name of the room
        public string name { get; private set; }

        /// <summary>
        /// Create a room with a name and a story
        /// </summary>
        /// <param name="aName"></param>
        /// <param name="aStory"></param>
        public Room(string aName, string aStory)
        {
            destinations = new List<Room>();
            name = aName;
            story = aStory;
        }
        /// <summary>
        /// Add a destination to the current room which will be shown in the console
        /// </summary>
        /// <param name="a room"></param>
        public void AddDestination(Room aRoom)
        {
            destinations.Add(aRoom);
        }
        
    }
}
