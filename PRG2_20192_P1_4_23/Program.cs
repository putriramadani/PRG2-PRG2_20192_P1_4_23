using System;

namespace PRG2_20192_P1_4_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilihan;
            Double alas, tinggi, luas, hipo, keliling;
           
            BacktoMenu:
            
            Console.WriteLine("MENU SEGITIGA SIKU-SIKU");
            Console.WriteLine("a. Hitung Luas");
            Console.WriteLine("b. Hitung Hipotunesa");
            Console.WriteLine("c. Hitung Keliling");
            Console.WriteLine("d. keluar");
            Console.Write("\nMenu Pilihan : ");
            pilihan = Convert.ToInt16(Console.ReadLine());
            switch (pilihan)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("LUAS SEGITIGA\n");
                    Console.Write("Masukkan Alas : ");
                    alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan tinggi : ");
                    tinggi = Convert.ToDouble(Console.ReadLine());
                    luas = alas * tinggi / 2;
                    Console.Write("\nLuas Segitiga dengan alas {0} dan tinggi {1} adalah {2} satuan\n\n", alas, tinggi, luas);
                    Console.Clear(); goto BacktoMenu;  break;

                case 2:
                    Console.Clear();
                    Console.WriteLine("HIPOTENUSA SEGITIGA\n");
                    Console.Write("Masukkan Alas : "); 
                    alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Tinggi : ");
                    tinggi = Convert.ToDouble(Console.ReadLine());
                    hipo = Math.Sqrt(alas * alas + tinggi * tinggi);
                    Console.Write("\nSisi Miring (Hipotenusa) adalah : {0} \n\n", hipo);
                    Console.Clear(); goto BacktoMenu; break;

                case 3:
                    Console.Clear();
                    Console.Write("\nKELILING SEGITIGA\n");
                    Console.Write("\nMasukkan Alas : "); 
                    alas = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Masukkan Tinggi : "); 
                    tinggi = Convert.ToDouble(Console.ReadLine());
                    hipo = Math.Sqrt(alas * alas + tinggi * tinggi);
                    keliling = hipo + alas + tinggi;
                    Console.Write("\nKeliling Segitiga : {0} \n\n", keliling);
                    Console.Clear(); goto BacktoMenu; break;

                case 4:
                    Environment.Exit(0); break;

                default: Console.WriteLine("Masukkan Salah"); break;
            }
        }
    }
}



 
