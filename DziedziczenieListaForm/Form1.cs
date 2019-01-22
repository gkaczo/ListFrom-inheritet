using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DziedziczenieListaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLosuj_Click(object sender, EventArgs e)
        {
            myLst.Items.Clear();

            Random rnd = new Random();
            int n = int.Parse(txtIlosc.Text);
            int A = int.Parse(txtA.Text);
            int B = int.Parse(txtB.Text);
            int los;
            for (int i=0;i<n;i++)
            {
                los = rnd.Next(A, B + 1);
                myLst.Items.Add(los);
                lstBoxSystem.Items.Add(los);
            }
            
        }

        private void btnSortuj_Click(object sender, EventArgs e)
        {
            myLst.SortujLiczby();
            lstBoxSystem.Sorted = true;
        }

        private void btnSumaLiczb_Click(object sender, EventArgs e)
        {
            MessageBox.Show(myLst.SumujLiczby().ToString());
        }
    }
}
