using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patika_try_catch_odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş oldugunuz sayi :" + sayi);

            }
            catch (Exception ex)
            {

                Console.Write("Hata"+ex.ToString());

            }
            //finally
            //{
            //    Console.WriteLine("İslem tamamlandı");
            //}

            try
            {

                int a = int.Parse(null);
            }
            catch (ArgumentException ex)
            {

                Console.WriteLine("Bos deger girdiniz");
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun degil.");
                Console.WriteLine(ex);
            }


            
        }
    }
}
