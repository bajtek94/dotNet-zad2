using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tablice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyArray tab = new MyArray();
            //int a = 5;
            //a = tab[6];
            tab.Add(1);
            tab.Add(2);
            tab.Add(5);
            tab[634] = 43;
            //Console.WriteLine(a);
        }



    }
}
