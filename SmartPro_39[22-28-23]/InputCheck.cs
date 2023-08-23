using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPro_39_22_28_23_
{
    internal class InputCheck
    {
        public static bool IntegerHaveCheck(string metin)
        {
            foreach (char item in metin)
            {
                if (char.IsDigit(item))
                {
                    return true;
                }
            }
            return false;
        }
        public static string StringGetCheck(string metin)
        {
            string text = string.Empty;
            bool error = true;
            do
            {
                Console.Write(metin);
                text = Console.ReadLine();
                if (IntegerHaveCheck(text))
                {
                    Console.WriteLine("Sayısal ifade girmeyiniz!");
                    error = true;
                }
                else if (string.IsNullOrEmpty(text))
                {
                    Console.WriteLine("Boş bırakılamaz!");
                    error = true;
                }
                else
                {
                    error = false;
                }

            } while (error);
            return text;
        }
        public static int IntegerGetCheck(string metin, int min = int.MinValue, int max = int.MaxValue)
        {
            int number = 0;
            bool error = true;
            do{
                Console.Write(metin);
                try{
                    number = int.Parse(Console.ReadLine());
                    if (number >= min && number <= max){
                        error = false;
                    }
                    else{
                        error = true;
                        Console.WriteLine("Girilen sayı {0} ile {1} arasında olmalıdır!",min,max);
                    }
                }
                catch (Exception e){
                    Console.WriteLine(e.Message+"\n");

                    
                }
            }
            while (error);
            return number;
        }
        public static double DoubleGetCheck(string metin, double min = double.MinValue, double max = double.MaxValue)
        {
            double sayi = 0;
            bool error = true;
            do
            {
                Console.Write(metin);
                try
                {
                    sayi = double.Parse(Console.ReadLine());
                    if (sayi >= min && sayi <= max)
                    {
                        error = false;
                    }
                    else
                    {
                        error = true;
                        Console.WriteLine("Girilen sayı {0} ile {1} aralığında olmalı", min, max);
                        Console.WriteLine();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    error = true;

                }


            } while (error);
            return sayi;
        }
    }
}
