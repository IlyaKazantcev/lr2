using System;
namespace Answer
{
    class Lab
    {
        static void Main()
        {
            Console.WriteLine(">> Вводите слова, завершая каждое нажатием Enter");
            Console.WriteLine(">> Для выхода наберите \"exit\"");

            var word = "";
            var maxlength = 0;
            var lngword = word;
            do
            {
                Console.Write(">> ");
                word = Console.ReadLine();
                if (word.Length > maxlength)
                {
                    maxlength = word.Length;
                    lngword = word.ToUpper();
                }
            }

            while (word != "exit");
            Console.WriteLine(">>");
            Console.WriteLine(">> Считывание завершено");
            Console.WriteLine($"Самое длинное слово: { lngword } ");
            Console.ReadKey();


        }
    }
}

    