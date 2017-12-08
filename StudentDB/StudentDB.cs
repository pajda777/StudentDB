using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{
    class StudentDB
    {
        const int delkaPole = 10;
        string[] jmena = new string[5] {"a","b", "c" , "d","e" };
        string[] prijmeni = new string[5] { "a", "b", "c", "d", "e" };
        public Student[] poleStudentu = new Student[delkaPole];
        public ArrayList seznamStudentu = new ArrayList();

        public void LoadStudenty()
        {
            Random nahodneCislo = new Random();
            for (int i = 0; i < poleStudentu.Length; i++)
            {
                Student student;
                student.Jmeno = jmena[nahodneCislo.Next(jmena.Length)];  
                student.Prijmeni = prijmeni[nahodneCislo.Next(prijmeni.Length)];
                student.Vek = nahodneCislo.Next(15, 80);

                poleStudentu[i] = student;
                seznamStudentu.Add(student);
            }


        }
        public bool Sestrid(Student[] studenti,out Student[] setridenePole)
        {
            bool byloTrideno = false;
            setridenePole = (Student[]) studenti.Clone();
            for(int i= 0; i < setridenePole.Length;i++ )
            {
                for(int j = 0; j < setridenePole.Length -1;j++ )
                {
                    if(setridenePole[j].Vek > setridenePole[j+1].Vek)
                    {
                        Student tempStudent = setridenePole[j + 1];
                        setridenePole[j + 1] = setridenePole[j];
                        setridenePole[j] = tempStudent;
                        byloTrideno = true;
                    }

                }
            }
            return byloTrideno;
        }



    }
}
