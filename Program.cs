using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{

   
    internal class Program
    {
        static void main(string[] args)
        {
          

        }
        static void Main(string[] args)
        {

            Console.Title = "Aplikasi Kalkulator";

            Console.Write("\n1. Penjumlahan ");
            Console.Write("\n2. Pengurangan ");
            Console.Write("\n3. Perkalian ");
            Console.Write("\n4. Pembagian ");

            Console.Write("\npilih : ");
            int pilih = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai : ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Masukkan nilai : ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nHasil Penjumlahan " + a + " + " + b + " = " + tambah(a, b));
            Console.WriteLine("\nTekan bebas untuk keluar");
            Console.ReadKey();
        }
        static int tambah(int a, int b)
        {
            return a + b;
        }
        static int kurang(int a, int b)
        {
            return a - b;
        }
        static int kali(int a, int b)
        {
            return a * b;
        }
        static int bagi(int a, int b)
        {
            return a / b;
        }
    }
}
