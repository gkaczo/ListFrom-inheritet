using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace DziedziczenieListaForm
{
    class myList:ListBox
    {
        public myList()
        {


        }

        public void SortujLiczby()
        {
            List<int> lst = new List<int>();
            foreach (int x in this.Items)
            {
                lst.Add(x);
            }
            lst.Sort();

            this.Items.Clear();

            foreach (int x in lst)
            {
                this.Items.Add(x);
            }
        }

        public int SumujLiczby()
        {
            int suma = 0;
            foreach (int x in this.Items)
            {
                suma = suma + x;
            }
            return suma;

        }

    }
}
