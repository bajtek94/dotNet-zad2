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
            tab.Add(1);
            tab.Add(2);
            tab.Add(5);
            tab.Add(54);
            tab.Add(523);
            tab.Add(235);
            tab.Add(615);
            tab.Add(235);
            tab.Add(615);
            tab.Add(35);
            tab.Add(65);
            tab.Add(125);
            tab[634] = 43;
            try
            {
                Console.WriteLine(tab[635]);
            } catch
            {
                Console.WriteLine("Błąd: Zły indeks");
            }
            Console.WriteLine(tab[632]);
            Console.WriteLine(tab[32]);
            Console.WriteLine(tab[156]);
            Console.WriteLine(tab[9]);
            tab.Add(23);
            Console.WriteLine(tab[635]);
        }



    }
}
