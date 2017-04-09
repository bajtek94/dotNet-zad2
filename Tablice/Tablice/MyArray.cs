using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    class MyArray
    {
        int[] tab;
        int countOfElements;

        public MyArray()
        {
            countOfElements = 0;
            tab = new int[4];
        }

        public int this[int el]
        {
            get
            {
                try
                {
                    return tab[el];
                }catch(Exception ex)
                {
                    Console.WriteLine("Error ! ! !");
                }
                return 0;
            }
            set
            {
                if (el >= countOfElements)
                {
                    growTab(el+1);
                    countOfElements = el+1;
                } 
                tab[el] = value;
            }
        }

        public void Add(int el)
        {
            int count = tab.Count();
            if (countOfElements >= count)
            {
                growTab(2 * count);
            }
            //Console.WriteLine("Rozmiar: " + count)
            tab[countOfElements] = el;
            countOfElements++;
        }

        private void growTab(int newSize)
        {
            int count = tab.Count();
            Console.WriteLine("Stary rozmiar: " + count);
            Array.Resize(ref tab, newSize);
            Console.WriteLine("Zwiększono rozmiar do: " + tab.Count());
            //tab = new int[count * 2];
        }
    }
}
