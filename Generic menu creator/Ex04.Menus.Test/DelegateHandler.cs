using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;


namespace Ex04.Menus.Test
{
    public class DelegateHandler
    {
        private readonly MainMenu r_Menu;

        public DelegateHandler(string i_MenuTitle)
        {
            r_Menu = new MainMenu(i_MenuTitle);
            SubMenuItem subMenu = new SubMenuItem("Version and Spaces", r_Menu.MenuLevel + 1);
            subMenu.AddToSubMenu(new MenuItemOperation("Show Version", new MethodsOfMenu.ShowVersion().ExecuteItemOperation));
            subMenu.AddToSubMenu(new MenuItemOperation("Count Spaces", new MethodsOfMenu.CountSpaces().ExecuteItemOperation));
            r_Menu.AddItemToList(subMenu);

            subMenu = new SubMenuItem("Show Date/Time", r_Menu.MenuLevel + 1);
            subMenu.AddToSubMenu(new MenuItemOperation("Show Time", new MethodsOfMenu.ShowTime().ExecuteItemOperation));
            subMenu.AddToSubMenu(new MenuItemOperation("Show Date", new MethodsOfMenu.ShowDate().ExecuteItemOperation));
            r_Menu.AddItemToList(subMenu);
        }

        public void Show()
        {
            r_Menu.Show();
        }

    }
}
