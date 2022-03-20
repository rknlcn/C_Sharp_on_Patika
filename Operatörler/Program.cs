﻿using System;

namespace Operatorler
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atama ve İşlemli Atama*********************");
            //Atama ve İşlemli Atama
            int x = 3;
            int y = 3;

            y = y + 2;  //y değerini 2 arttırmak
            Console.WriteLine(y);
            y += 2;     //kısayolu
            Console.WriteLine(y);

            y /= 1;
            Console.WriteLine(y);
            x *= 2;
            Console.WriteLine(x);

            Console.WriteLine("Mantıksal Operatörler*********************");
            //Mantıksal Operatörler
            // ||veya , &&ve , !değil

            bool isSucces = true;
            bool isCompleted = false;

            if (isSucces && isCompleted)
            {
                Console.WriteLine("Perfect!");
            }

            if (isSucces || isCompleted)
            {
                Console.WriteLine("Great!");
            }

            if (isSucces && !isCompleted)
            {
                Console.WriteLine("Fine!");
            }


            Console.WriteLine("İlişkisel Operatörler*************************");
            //İlişkisel Operatörler
            //< , > , <= , >= , == , !=

            int a = 3;
            int b = 4;

            bool sonuc = a < b;
            Console.WriteLine(sonuc);

            sonuc = a > b;
            Console.WriteLine(sonuc);

            sonuc = a >= b;
            Console.WriteLine(sonuc);

            sonuc = a <= b;
            Console.WriteLine(sonuc);

            sonuc = a == b;
            Console.WriteLine(sonuc);

            sonuc = a != b;
            Console.WriteLine(sonuc);


            Console.WriteLine("Aritmetik Operatörler*************************");
            // / , * , + , -

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1 / sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1 * sayi2;
                        Console.WriteLine(sonuc1);
            sonuc1 = sayi1 + sayi2;
                        Console.WriteLine(sonuc1);
            sonuc1 = sayi1++;
                        Console.WriteLine(sayi1);

            // % mod alır. bölme işleminden kalanı hesaplar.
            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);
        }
    }
}