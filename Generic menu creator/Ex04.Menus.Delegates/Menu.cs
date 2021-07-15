using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{ 
    public abstract class Menu
    {
        private readonly int r_MenuLevel;
        private string m_MenuTitle;
        protected string m_Quit;
        private readonly List<MenuItem> r_MenuItems;

        protected Menu(string i_MenuTitle, string i_Quit, int i_MenuLevel)
        {
            m_MenuTitle = i_MenuTitle;
            r_MenuItems = new List<MenuItem>();
            m_Quit = i_Quit;
            r_MenuLevel = i_MenuLevel;
        }

        public void Item_Chosen(MenuItem i_InvokerItem)
        {
            i_InvokerItem.HandleChosenItem();
        }

        public void AddItemToList(MenuItem i_MenuItem)
        {
            r_MenuItems.Add(i_MenuItem);
            i_MenuItem.ChosenEventHandler += this.Item_Chosen;
        }

        public void Show()
        {
            bool isQuit = false;
            int userInput;

            while (!isQuit)
            {
                Console.WriteLine("Title: " + MenuTitle);
                Console.WriteLine("Level: " + r_MenuLevel);
                PrintRequestMessageToUser();
                PrintMenuItemTitles();
                userInput=GetUserChoice();
                Console.Clear();
                
                if (userInput == 0)
                {
                    isQuit = true;
                }
                else
                {
                    r_MenuItems[userInput - 1].DoWhenSelected();
                }
            }
        } 

        public int GetUserChoice()
        {
            bool isGoodInput = int.TryParse(Console.ReadLine(), out int userInput);

            while (!isGoodInput || userInput < 0 || userInput > MenuItems.Count)
            {
                Console.WriteLine("Invalid input! Please enter again (must be a number between 0 - {0}): ", MenuItems.Count);
                isGoodInput = int.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;
        }

        public void PrintMenuItemTitles()
        {
            int menuItemsCounter = 1;

            Console.WriteLine("0. " + m_Quit);
            foreach (MenuItem item in r_MenuItems)
            {
                Console.WriteLine(menuItemsCounter.ToString() + ". " + item.ItemTitle);
                menuItemsCounter++;
            }
        }

        public void PrintRequestMessageToUser()
        {
            Console.WriteLine("Please choose from the following options (a number between 0-{0}):", r_MenuItems.Count);
        }

        public int MenuLevel
        {
            get
            {
                return r_MenuLevel;
            }
        }

        public string MenuTitle
        {
            get
            {
                return m_MenuTitle;
            }
            set
            {
                m_MenuTitle = value;
            }
        }

        public List<MenuItem> MenuItems
        {
            get
            {
                return r_MenuItems;
            }
        }

        public string Quit
        {
            get
            {
                return m_Quit;
            }
        }
    }
}
