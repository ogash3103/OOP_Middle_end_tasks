using System;
using System.Configuration;



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

/*List<Abtomobil> abtomobils = new List<Abtomobil>{};

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
 */

//  ========== task end 2 ============


   List<Boksiyor> boksiyors = new List<Boksiyor>
        {
            new Boksiyor { _id = 1, _name = "Sardor", _surname = "Baxriddinov", _age = 20, _weight = 60.35f },
            new Boksiyor { _id = 2, _name = "Ali", _surname = "Valiyev", _age = 25, _weight = 45.20f },
            new Boksiyor { _id = 3, _name = "Bekzod", _surname = "Karimov", _age = 28, _weight = 75.00f },
            new Boksiyor { _id = 4, _name = "Jamshid", _surname = "Toshmatov", _age = 30, _weight = 90.50f }
        };

 var lightweightBoxers = boksiyors.Where(b => b._weight < 50).ToList();
 var middleweightBoxers = boksiyors.Where(b => b._weight >= 50 && b._weight < 76).ToList();
 var heavyweightBoxers = boksiyors.Where(b => b._weight >= 90).ToList();

        Console.WriteLine("\nYengil vaznli bokschilar:");
        PrintBoxers(lightweightBoxers);

        Console.WriteLine("\nO'rta vaznli bokschilar:");
        PrintBoxers(middleweightBoxers);

        Console.WriteLine("\nOg'ir vaznli bokschilar:");
        PrintBoxers(heavyweightBoxers);


        }
         
         static void PrintBoxers(List<Boksiyor> boxers)
         {
                if (!boxers.Any())
                {
                    Console.WriteLine($"Bokschilar topilmadi.");
                    return;
                }

                foreach (var boxer in boxers)
                {
                    Console.WriteLine($"ID: {boxer._id}, Name: {boxer._name}, Surname: {boxer._surname}, Age: {boxer._age}, Weight: {boxer._weight} kg\n");
                }
    }
    }
}
