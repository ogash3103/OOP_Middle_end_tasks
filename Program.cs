using System;

namespace _OOP_MIDDLE_END_TASKS
{
    class Program
    {
        static void Main()
        {
         
        //  ========== task start 1 ============

       /* Console.Write("Talabaning Idsini kiriting: "); 
        int inputId = int.Parse(Console.ReadLine()!);

        Console.Write("Talabaning Ismini kiriting: "); 
        string inputName = Console.ReadLine()!;

        Console.Write("Talabaning Failyasini kiriting: "); 
        string inputSurName = Console.ReadLine()!;

        Console.Write("Talabaning sinif raqmini kiriting: "); 
        int inputClass = int.Parse(Console.ReadLine()!);

         Console.Write("Talabaning olgan baxosini kiriting: "); 
        decimal inputRating = decimal.Parse(Console.ReadLine()!);

        Student student = new Student(inputId, inputName, inputSurName, inputClass, inputRating);

        student.DisplayInfo();
        student.BaxoDarajalari((int)inputRating); */

//  ========== task end 1 ============

//  ========== task start 2 ============

List<Abtomobil> abtomobils = new List<Abtomobil>{};

Console.Write("Nechta Abtomobil kiritmoqchisiz: ");
int inputCarsCount = int.Parse(Console.ReadLine()!);

for (int i = 0; i < inputCarsCount; i++)
{
    Console.WriteLine($"\n{i + 1} => avtomobil uchun ma'lumot kiriting: ");

    Console.Write("Modelni kiriting: ");
    string name = Console.ReadLine()!;

    Console.Write("Markani kiriting: ");
    string brand = Console.ReadLine()!;

    Console.Write("Narxni kiriting: ");
    decimal price = decimal.Parse(Console.ReadLine()!);

    abtomobils.Add(new Abtomobil(name, brand, price));
}

Console.WriteLine("\nRo'yxatdagi barcha avtomobillar:");
foreach (var car in abtomobils)
 {
    car.DisplayInfo();
 }

Console.Write("\nEng past narxni kiriting: ");
decimal lowerPrice = decimal.Parse(Console.ReadLine()!);

Console.Write("Eng yuqori narxni kiriting: ");
decimal upperPrice = decimal.Parse(Console.ReadLine()!);

Console.WriteLine("\nBerilgan narx oralig'idagi avtomobillar:");
bool found = false;

 foreach (var car in abtomobils)
        {
            if (car._avtoPrice >= lowerPrice && car._avtoPrice <= upperPrice)
            {
                car.DisplayInfo();
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine("Berilgan narx oralig'ida avtomobillar topilmadi.");
        }


//  ========== task end 2 ============

        



        }
    }
}
