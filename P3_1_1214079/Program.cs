using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_1214079
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("ANAK AYAM TURUN");
            a = int.Parse(Console.ReadLine());

            if (a > 10 || a <= 0)
            {
                Console.WriteLine("Gagal");
            }
            else
            {
                for (int i = a; i >= 1; i--)
                {



                    if (i == 1)
                    {
                        Console.WriteLine("anak ayam turunlah 1 " + "mati satu tinggal induknya");
                    }
                    else
                    {
                        Console.WriteLine("anak ayam turunlah " + i + "," + "Matilah satu tinggallah " + (i - 1));
                    }

                }
            }
        }
    }
}
