using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_10_For_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //For Döngüsü kullanılarak Kullanıcıdan 10 adet isim alarak başına numaraların da ekleyerek ekranda yazdıran örnek:

            string İsim;
            int j = 1;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Bir İsim Giriniz:");
                İsim = Console.ReadLine();

                Console.WriteLine(j+". Kişi {0}",İsim);

                j++;
            }

            Console.ReadKey();
        }
    }
}
