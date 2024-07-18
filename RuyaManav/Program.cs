using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rüya manavında fiyatlar çok uygun!");
        Console.WriteLine("Elma = 2 TL\nArmut = 3 TL\nÇilek = 2 TL\nMuz = 3 TL\nDiğer bütün meyveler = 4 TL");
        Console.Write("Hangi meyveyi satın almak istersiniz? ");

        string meyve = Console.ReadLine().ToLower(); // Büyük küçük harf duyarlılığı için ToLower kulandım.
        int fiyat = 0;

        /*(if (meyve == "elma")
        {
            fiyat = 2;
        }
        else if (meyve == "armut")
        {
            fiyat = 3;
        }
        else if (meyve == "çilek")
        {
            fiyat = 2;
        }
        else if (meyve == "muz")
        {
            fiyat = 3;
        }
        else
        {
            fiyat = 4;
        }*/


        switch (meyve) // Bu örnek için switch case kullanımının daha uygun olacağını düşünüyorum.
        {
            case "elma":
                fiyat = 2;
                break;
            case "armut":
                fiyat = 3;
                break;
            case "çilek":
                fiyat = 2;
                break;
            case "muz":
                fiyat = 3;
                break;
            default:
                fiyat = 4;
                break;
        }

     

            Console.WriteLine($"{meyve} fiyatı: {fiyat} TL");
        }
    }

