using System;

namespace Ortalama_hesaplama
{

    class Program
    {
        static void Main(string[] args)
        {
            double sinav1, sinav2, ortalama;
            Console.WriteLine("1.sınav Notunu Giriniz.");
            sinav1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2.sınav Notunu Giriniz.");
            sinav2 = Convert.ToDouble(Console.ReadLine());
            ortalama = (sinav1 * 50/100) + (sinav2 * 50/100);

           if (ortalama<=100)
            {
                Console.WriteLine("Ortalamanız:"+ ortalama);
            } 
        }
    }







}