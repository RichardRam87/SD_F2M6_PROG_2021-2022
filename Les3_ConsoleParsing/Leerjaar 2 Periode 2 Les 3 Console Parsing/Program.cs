using System;

namespace Leerjaar_2_Periode_2_Les_3_Console_Parsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create the framework
            Story story = new Story();

            //create rooms
            Room corridor = new Room("Corridor", "You're in a shiny corridor, the atmosphere is daft and you forgot why you even came here");
            Room library = new Room("Library", "You enter the library, the fire place is lit, giving off a comfortable hue");
            Room kitchen = new Room("Kitchen", "You enter the kitchen, there is food on the counter, but it looks like it has been there for ages");
            Room upstairs = new Room("Hallway", "You ascent the stairs, the rug is old and daft, still there is no sign of life");
            Room bedRoom = new Room("Bedroom", "You enter the bedroom, clearly time for a little nap");
            Room sleep = new Room("Sleep", "You fall asleep, and you never wake again.... TUMTUMTUUUUM");

            //Add the destinations to the rooms
            corridor.AddDestination(library);
            library.AddDestination(corridor);
            corridor.AddDestination(kitchen);
            kitchen.AddDestination(corridor);
            corridor.AddDestination(upstairs);
            bedRoom.AddDestination(upstairs);
            upstairs.AddDestination(bedRoom);
            bedRoom.AddDestination(sleep);
            upstairs.AddDestination(corridor);

            //define the starting room
            story.startRoom = corridor;

            while (true)
            {
                //run the story with int input
                //story.Run();
                story.RunArrowInput();
            }
        }
    }
}
