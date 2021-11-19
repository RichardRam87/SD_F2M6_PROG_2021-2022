using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leerjaar_2_Periode_2_Les_3_Console_Parsing
{
    class Story
    {
        public Room startRoom { get; set; }
        private Room currentRoom;
        public Story()
        {
            
        }

        public void Run()
        {
            if (currentRoom == null)
            {
                currentRoom = startRoom;
            }
            Console.WriteLine($"You're in the {currentRoom.name}\n");
            Console.WriteLine(currentRoom.story + "\n");
            Console.WriteLine("Where do you want to go?");
            for(int i = 0; i < currentRoom.destinations.Count; i++)
            {
                Console.WriteLine($"{i} - {currentRoom.destinations[i].name}");
            }
            int choice = AskForInput(currentRoom.destinations.Count);
            currentRoom = currentRoom.destinations[choice];
            
        }
        private int AskForInput(int maxNumber)
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))
            {
                if(input < maxNumber)
                {
                    return input;
                }
                Console.WriteLine("Ongeldige input: Optie niet beschikbaar");
            }
            Console.WriteLine("Ongeldige input: Geef een getal op");
            return AskForInput(maxNumber);
        }

    }
}
