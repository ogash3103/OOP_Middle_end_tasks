using System;

namespace _OOP_MIDDLE_END_TASKS
{
    class Program
    {
        static void Main()
        {
         
        //  ========== task start 1 ============
        
        Console.Write("Talabaning Idsini kiriting: "); 
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
        student.BaxoDarajalari((int)inputRating);

//  ========== task end 1 ============

        



        }
    }
}
