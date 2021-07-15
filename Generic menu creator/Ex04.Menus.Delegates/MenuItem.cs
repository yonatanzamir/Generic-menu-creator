using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        public event Action<MenuItem> ChosenEventHandler;
        private string m_ItemTitle;

        protected MenuItem(string i_ItemTitle)
        {
            m_ItemTitle = i_ItemTitle;
        }

        internal void DoWhenSelected()
        {
            OnChosen();
        }

        protected virtual void OnChosen()
        {
            if(ChosenEventHandler != null)
            {
                ChosenEventHandler.Invoke(this);
            }
            else
            {
                Console.WriteLine("No listeners for " + m_ItemTitle);
            }
        }

        public abstract void HandleChosenItem();

        public string ItemTitle
        {
            get
            {
                return m_ItemTitle;
            }

            set
            {
                m_ItemTitle = value;
            }
        }
    }
}
