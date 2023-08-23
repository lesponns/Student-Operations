using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_39_22_28_23_
{
    internal static class Menu
    {
        static List<Student> students = new List<Student>();

        public static void Processes(ConsoleKey secim)
        {
            switch (secim) 
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    StudentAdd("Öğrenci Ekleme Ekranı");
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    StudentDelete("Öğrenci Silme Ekranı");
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    StudentList("Öğrenci Listeleme Ekranı");
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    StudentSearch("Öğrenci Arama Ekranı");
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    StudentAll("Toplam Öğrenci Sayısı");
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    StudentAllAverage("Öğrencilerin Genel Ortalaması");
                    break;
                case ConsoleKey.D0:
                case ConsoleKey.NumPad0:

                    break;
            }
        }
        private static void returnHome(string metin)
        {
            Console.WriteLine();
            Console.WriteLine(metin);
            Console.WriteLine("Ana menüye dönmek için herhangi bir tuşa basınız");
            Console.ReadKey();
        }
        private static void HeaderPrint(string metin)
        {
            Console.Clear();
            Console.WriteLine(metin);
            Console.WriteLine("----------------");
            Console.WriteLine();
        }
        private static void StudentAdd(string metin)
        {
            HeaderPrint(metin);
            Student ogr = new Student();
            ogr.name = InputCheck.StringGetCheck("Öğrencinin Adını Giriniz : ");
            ogr.surname = InputCheck.StringGetCheck("Öğrenci Soyadını Giriniz : ");
            ogr.schoolnumber = InputCheck.IntegerGetCheck("Öğrencinin Okul No sunu Giriniz : ");
            ogr.n1 = InputCheck.DoubleGetCheck("Öğrencinin 1.Sınav Notunu Giriniz : ", 1, 100);
            ogr.n2 = InputCheck.DoubleGetCheck("Öğrencinin 2.Sınav Notunu Giriniz : ", 1, 100);
            students.Add(ogr);
            returnHome("Kayıt İşlemi Başarılı Bir Şekilde Gerçekleşti");
        }
        private static void StudentDelete(string metin)
        {
            HeaderPrint(metin);
            if (students.Any())
            {
                for (int i = 0; i < students.Count; i++)
                {
                    students[i].print(i+1);
                }
                int Squence = InputCheck.IntegerGetCheck("Silmek istediğiniz öğrencinin sıra numarasını giriniz: ");
                students.RemoveAt(Squence - 1);
                returnHome("Silme İşlemi Başarıyla Gerçekleşti.");
            }
            else
            {
                returnHome("Kayıtlı Öğrenci bulunamadı.");
            }
        }
        private static void StudentList(string metin)
        {
            HeaderPrint(metin);
            if (students.Any()) 
            {
                foreach (var item in students)
                {
                    item.print();
                    Console.Write("\n_______________\n");
                }
                returnHome(string.Format("Toplam {0} adet öğrenci listelenmiştir.",students.Count));
            }
            else
            {
                returnHome("Kayıtlı Öğrenci bulunamadı.");
            }
        }
        private static void StudentSearch(string metin)
        {
            HeaderPrint(metin);
            if(students.Any())
            {
                string searchingstudent = InputCheck.StringGetCheck("Aramak istediğiniz Öğrencinin adını veya soyadını giriniz: ");
                int adet = 0;
                foreach (var item in students)
                {
                    if (item.LongName.ToLower().Contains(searchingstudent.ToLower()))
                    {
                        adet++;
                        item.print(adet);
                    }
                }
                returnHome(string.Format("{0} kelimesine karşılık {1} tane sonuç bulunmuştur.",searchingstudent,adet));
            }
            else
            {
                returnHome("Kayıtlı Öğrenci Bulunamadı.");
            }
        }
        private static void StudentAll(string metin)
        {
            HeaderPrint(metin);
            if (students.Any())
            {
                returnHome(string.Format("{0} adet öğrenci kayıtlı.",students.Count));
            }
            else
            {
                returnHome("Kayıtlı öğrenci bulunamadı.");
            }
        }
        private static void StudentAllAverage(string metin)
        {
            HeaderPrint(metin);
            if (students.Any())
            {
                double AllAvarage = 0;
                foreach (var item in students)
                {
                    AllAvarage += item.avarage;
                }
                double LastAvarage = AllAvarage / students.Count;
                returnHome(string.Format("{0} adet öğrencinin genel not ortalaması: {1}", students.Count, Math.Round(LastAvarage, 2)));
            }
            else 
            {
                returnHome("Kayıtlı öğrenci bulunamadı.");
            }
        }
    }
}
