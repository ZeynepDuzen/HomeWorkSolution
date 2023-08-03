using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //switchcase'de sadece esitlik durumları sözkonusudur
            //int? sayi = null; // ? isareti nullable yapmak icin kullanılır --> bos yapmak --> null yapılabilir

            //switch (sayi)
            //{
            //    case 0:
            //        break;
            //    case 1:
            //        break;
            //    case 2:
            //    case 3:
            //    case 4: // sayi ==2 || sayi ==4 || sayi==5 (birden fazla esitlik için kullanılabillir)
            //        break;
            //    default:
            //        //(else gibi)  
            //        //default herzaman sonda yazılmak zorunda degil, iki case arasında veya en basta da olabilir.
            //        break;
            //}

            // *** kullanicidan alinan aşagıdaki plaka kodlaına gore sehirlerin isimlerini veren switch case yapisini kodlayin ***

            //Console.WriteLine("Lütfen bir plaka girin");
            //int plaka = Convert.ToInt16(Console.ReadLine());

            //SehirGetir(plaka);

            // *** yılın ay bilgisine göre mevsim ***
            //Console.WriteLine("Lütfen ay ismi girin  :");
            //string ay = Console.ReadLine();
            //MevsimGetir(ay);

            

            Console.Read();
        }

        static void SehirGetir(int plaka)
        {
            switch (plaka)
            {
                case 34:
                    Console.WriteLine("İstanbul");
                    break;
                case 65:
                    Console.WriteLine("Van");
                    break;
                case 44:
                    Console.WriteLine("Malatya");
                    break;
                case 49:
                    Console.WriteLine("Muş");
                    break;
                case 35:
                    Console.WriteLine("İzmir");
                    break;
                case 01:
                    Console.WriteLine("Adana");
                    break;
                case 30:
                    Console.WriteLine("Hakkari");
                    break;
                case 06:
                    Console.WriteLine("Ankara");
                    break;
                default:
                    Console.WriteLine("Plaka kodları güncellenecek");
                    break;


            }
        }
            
       static void MevsimGetir(string ay)
        {
            switch (ay)
            {
                case "Aralik":
                case "Ocak":
                case "Subat":
                    Console.WriteLine("Kıs mevsimi");
                    break;
                case "Mart":
                case "Nisan":
                case "Mayis":
                    Console.WriteLine("İlkbahar mevsimi");
                    break;
                case "Haziran":
                case "Temmuz":
                case "Agustos":
                    Console.WriteLine("Yaz mevsimi");
                    break;
                case "Eylul":
                case "Ekim":
                case "Kasim":
                    Console.WriteLine("Sonbahar mevsimi");
                    break;
                default:
                    Console.WriteLine("Gecersiz ay ismi girdiniz");
                    break;
            }
        }

    }
}

