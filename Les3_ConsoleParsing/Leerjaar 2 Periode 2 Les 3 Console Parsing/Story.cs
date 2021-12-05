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
        public Room currentRoom { get; private set; }

        private int selectionArrowIndex = 0;
        public Story()
        {
            
        }
        /// <summary>
        /// Runs the story and asks for input
        /// </summary>
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

        /// <summary>
        /// Run the story with arrow input
        /// </summary>

        public void RunArrowInput()
        {
            if(currentRoom == null)
            {
                currentRoom = startRoom;
            }
            Console.WriteLine($"You're in the {currentRoom.name}\n");
            Console.WriteLine(currentRoom.story);
            Console.WriteLine("Where do you want to go?");
            for(int i = 0; i < currentRoom.destinations.Count; i++)
            {
                if(i == selectionArrowIndex)
                {
                    Console.Write("->");
                }
                Console.Write($"\t{currentRoom.destinations[i].name}\n");
            }
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    if (selectionArrowIndex == 0)
                    {
                        selectionArrowIndex = currentRoom.destinations.Count - 1;
                    }
                    else
                    {
                        selectionArrowIndex--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (selectionArrowIndex < currentRoom.destinations.Count -1)
                    {
                        selectionArrowIndex++;
                    }
                    else
                    {
                        selectionArrowIndex = 0;
                    }
                    break;
                case ConsoleKey.Enter:
                    currentRoom = currentRoom.destinations[selectionArrowIndex];
                    selectionArrowIndex = 0;
                    break;
            }
            Console.Clear();
        }

        /// <summary>
        /// Ask for a number, when the input is invalid it retries.
        /// </summary>
        /// <param name="maxNumber"></param>
        /// <returns></returns>
        private int AskForInput(int maxNumber)
        {
            int input;
            if (int.TryParse(Console.ReadLine(), out input))  //if the input can be converted into an int
            {
                if(input < maxNumber)//when it's lower than the maximum accepted value
                {
                    return input;   //return the input
                }
                Console.WriteLine("Invalid Input: Option not available"); //otherwise it's either not a valid option
            }
            else
            {
                Console.WriteLine("Invalid Input: Please insert a number"); //or the input wasn't parsable
            }
            return AskForInput(maxNumber); //Retry on invalid input
        }
        

    }
}
