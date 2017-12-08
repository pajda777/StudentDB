using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDB databaze = new StudentDB();
            databaze.LoadStudenty();
            Student[] setrideniStudenti;
            bool trideno = databaze.Sestrid(databaze.poleStudentu,out setrideniStudenti);

            foreach(Student s in setrideniStudenti)
            {
                Console.WriteLine(s.Jmeno + " " + s.Prijmeni + " " + s.Vek);
            }
            Console.WriteLine("");
            foreach (Student s in databaze.poleStudentu)
            {
                Console.WriteLine(s.Jmeno + " " + s.Prijmeni + " " + s.Vek);
            }

            bool bylo;
            //if(trideno) bylo = true;
            int delka = (databaze.seznamStudentu.Count == 4) ? 4 : -1;

            Kolekce k = new Kolekce();
            k.NapnFrontu();
            k.NaplnZasobnik();
            k.NaplTabulku();

            Console.ReadLine();
        }
    }
}
