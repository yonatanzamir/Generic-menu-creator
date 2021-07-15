using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MainMenu : Menu
    {
        private const string k_Quit = "Exit";

        public MainMenu(string i_MenuTitle) : base(i_MenuTitle, k_Quit, 0)
        {
        }
    }
}
