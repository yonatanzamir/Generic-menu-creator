using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItem
    {
        private readonly List<IOptionObserver> r_OptionObservers;
        private string m_ItemTitle;

        protected MenuItem(string i_ItemTitle)
        {
            m_ItemTitle = i_ItemTitle;
            r_OptionObservers = new List<IOptionObserver>();
        }


        internal void AttachObserver(IOptionObserver i_OptionObserver)
        {
            r_OptionObservers.Add(i_OptionObserver);
        }

        internal void DetachObserver(IOptionObserver i_OptionObserver)
        {
            r_OptionObservers.Remove(i_OptionObserver);
        }

        internal void DoWhenSelected()
        {
            NotifyOptionObservers();
        }

        protected void NotifyOptionObservers()
        {
            foreach (IOptionObserver observer in r_OptionObservers)
            {
                observer.ReportOption(this);
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

        internal List<IOptionObserver> OptionObservers
        {
            get
            {
                return r_OptionObservers;
            }

        }
    }
}
