using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItemOperation: MenuItem
    {
        private readonly IOperational r_OperationObject;

        public interface IOperational
        {
             void ExecuteItemOperation();
        }

        public MenuItemOperation(string i_ItemTitle, IOperational i_OperationObject) : base(i_ItemTitle)
        {
            r_OperationObject = i_OperationObject;
        }

        public override void HandleChosenItem()
        {
            r_OperationObject.ExecuteItemOperation();
        }
    }
}
