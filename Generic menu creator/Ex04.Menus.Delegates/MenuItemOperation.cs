using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItemOperation: MenuItem
    {
        public delegate void OperationDelegete();

        private readonly OperationDelegete r_Operation;

        public MenuItemOperation(string i_ItemTitle, OperationDelegete i_Operation) : base(i_ItemTitle)
        {
            r_Operation += i_Operation;
        }

        public override void HandleChosenItem()
        {
            r_Operation.Invoke();
        }
    }
}
