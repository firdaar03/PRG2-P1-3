using System;

namespace PRG2_20192_P1_3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukkan jumlah anak ayam : ");
            int N = Convert.ToInt16(Console.ReadLine());

            for(int i = N; i > 0; i--)
            {
                if (i>1)
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal {1}", i, i - 1);
                }
                else
                {
                    Console.WriteLine("Anak ayam turun {0}, mati satu tinggal induknya", i);
                }
            }
        }
    }
}
