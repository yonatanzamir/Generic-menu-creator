using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class MethodsOfMenu
    {
        public class ShowVersion : MenuItemOperation.IOperational
        {
            public void ExecuteItemOperation()
            {
                Console.WriteLine("Version: 21.1.4.8930");
                Console.WriteLine();
            }
        }

        public class CountSpaces : MenuItemOperation.IOperational
        {
            public void ExecuteItemOperation()
            {
                Console.WriteLine("Please enter a sentence");
                int spacesCounter = 0;
                string userInput = Console.ReadLine();
                foreach (char character in userInput)
                {
                    if (character == ' ')
                    {
                        spacesCounter++;
                    }
                }

                Console.WriteLine("There are {0} spaces in the sentence ", spacesCounter);
                Console.WriteLine();
            }
        }

        public class ShowTime : MenuItemOperation.IOperational
        {
            public void ExecuteItemOperation()
            {
                Console.WriteLine("Current Hour: " + DateTime.Now.ToShortTimeString());
                Console.WriteLine();
            }
        }

        public class ShowDate : MenuItemOperation.IOperational
        {
            public void ExecuteItemOperation()
            {
                Console.WriteLine("Current Date: " + DateTime.Now.Date.ToShortDateString());
                Console.WriteLine();
            }
        }
    }
}

