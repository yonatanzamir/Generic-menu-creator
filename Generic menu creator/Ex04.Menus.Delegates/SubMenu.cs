using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class SubMenu: Menu
    {
        private const string k_Quit = "Back";

        public SubMenu(string i_MenuTitle, int i_SubMenuLevel) : base(i_MenuTitle, k_Quit, i_SubMenuLevel)
        {
        }
    }
}
