using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> kahveler = new List<string>();

        // Kullanıcıdan 5 kahve ismi alma
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Lütfen {0}. kahve ismini girin: ", i + 1);
            string kahve = Console.ReadLine();
            kahveler.Add(kahve);
        }

        // Kahve listesini foreach döngüsü ile yazdırma
        Console.WriteLine("\nKahve Listesi:");
        foreach (string kahve in kahveler)
        {
            Console.WriteLine(kahve);
        }
    }
}
