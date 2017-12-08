using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    class Kolekce
    {
        //fronta FIFO -  first in , first out
        Queue fronta = new Queue();
        //Zasobnik LIFO , last in , first out
        Stack zasobnik = new Stack();
        // hashtable
        Hashtable table = new Hashtable();

        
        public void NapnFrontu()
        {
            fronta.Enqueue("Pavel");
            fronta.Enqueue("Pepa");
            fronta.Enqueue("Jano");


            string s = (string) fronta.Dequeue();
            foreach(string c in  fronta)
            {
                Console.WriteLine(c);
            }
        }
        public void NaplnZasobnik()
        {
            zasobnik.Push(10);
            zasobnik.Push(5);
            zasobnik.Push("Pavel");
            zasobnik.Push("Peter");

            string s = zasobnik.Pop().ToString();
        }
        public void NaplTabulku()
        {
            table["Pavel Sanca"] = "564028323208";
            table["Jakub"] = "564028323208";
            table.Remove("Jakub");

        }

    }
}
