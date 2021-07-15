using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class InterfaceHandler
    {
        private readonly MainMenu r_Menu;

        public InterfaceHandler(string i_MenuTitle)
        {
            r_Menu = new MainMenu(i_MenuTitle);
            SubMenuItem subMenu = new SubMenuItem("Version and Spaces", r_Menu.MenuLevel + 1);
            subMenu.AddToSubMenu(new MenuItemOperation("Show Version", new MethodsOfMenu.ShowVersion()));
            subMenu.AddToSubMenu(new MenuItemOperation("Count Spaces", new MethodsOfMenu.CountSpaces()));
            r_Menu.AddItemToList(subMenu);

            subMenu = new SubMenuItem("Show Date/Time", r_Menu.MenuLevel + 1);
            subMenu.AddToSubMenu(new MenuItemOperation("Show Time", new MethodsOfMenu.ShowTime()));
            subMenu.AddToSubMenu(new MenuItemOperation("Show Date", new MethodsOfMenu.ShowDate()));
            r_Menu.AddItemToList(subMenu);
        }

        public void Show()
        {
            r_Menu.Show();
        }
    }
}
