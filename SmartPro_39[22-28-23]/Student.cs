using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_39_22_28_23_
{
    internal class Student
    {
        public string name, surname;
        public int schoolnumber;
        public double n1, n2;

        public double avarage
        {
            get
            {
                return (n1 + n2) / 2; 
            }
        }

        public string LongName
        {
            get { return name + " " + surname; }
        }

        public void print()
        {
            Console.WriteLine("Adı Soyadı: {0}",LongName);
            Console.WriteLine("Okul Numarası: {0}",schoolnumber);
            Console.WriteLine("Sınav Notları: {0}, {1}",n1,n2);
            Console.WriteLine("Not Ortalaması: {0}",avarage);

        }
        public void print(int Sequence)
        {
            Console.WriteLine("{0}. Öğrenci: {1}",Sequence,LongName);
        }
    }
}
