using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class SubMenuItem: MenuItem
    {
        private readonly SubMenu r_SubMenu;

        public SubMenuItem(string i_ItemTitle, int i_SubMenuLevel) : base(i_ItemTitle)
        {
            r_SubMenu = new SubMenu(i_ItemTitle, i_SubMenuLevel);
        }

        public void AddToSubMenu(MenuItem i_MenuItem)
        {
            r_SubMenu.AddItemToList(i_MenuItem);
        }

        public override void HandleChosenItem()
        {
            r_SubMenu.Show();
        }

        public SubMenu SubMenu
        {
            get
            {
                return r_SubMenu;
            }
        }
    }
}
