using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_39_22_28_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Program işlemleri
            /*
            Öğrenci Ekle
            Öğrenci sil
            Öğrencileri Listele
            Öğrenci Ara
            Toplam Öğrenci Sayısı
            Genel Not Ortalaması
            */
            #endregion
            ConsoleKey secim;
            do
            {
                Console.Clear();
                Console.WriteLine("Öğrenci Kayıt Programı");
                Console.WriteLine("------------------------");
                Console.WriteLine("1-Öğrenci Ekle ");
                Console.WriteLine("2-Öğrenci sil");
                Console.WriteLine("3-Öğrencileri Listele");
                Console.WriteLine("4-Öğrenci Ara");
                Console.WriteLine("5-Toplam Öğrenci Sayısı");
                Console.WriteLine("6-Genel Not Ortalaması");
                Console.WriteLine("0-Programı kapat");
                Console.Write("Hangi İşlemi Yapmak istersiniz ");
                secim = Console.ReadKey().Key;
                Menu.Processes(secim);
            }
            while (secim != ConsoleKey.D0 && secim != ConsoleKey.NumPad0);

            Console.Clear();
            Console.WriteLine("Programı Kullandığınız İçin Teşekkür Ederiz");
            Console.WriteLine("Çıkış Yapmak İçin Herhangi Bir Tuşa Basınız");
            Console.ReadKey();
        }
    }
}
