using System;

namespace ChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            // Рисуем шахматную доску.
            Console.WriteLine("   a b c d e f g h");
            for (int i = 8; i > 0; i--)
            {
                Console.Write(i + "  ");
                for (char j = 'a'; j <= 'h'; j++)
                {
                    if ((i % 2 == j % 2))
                    {
                        Console.Write("  ");
                    }
                    else
                    {
                        Console.Write("■ ");
                    }
                }
                Console.WriteLine();
            }

            // Ввод координат полей.
            Console.WriteLine("\nВведите координаты первого поля (например, e4):");
            string? input1 = Console.ReadLine();
            Console.WriteLine("Введите координаты второго поля (например, f5):");
            string? input2 = Console.ReadLine();

            // Проверка корректности введенных координат.
            if (input1.Length != 2 || input2.Length != 2 ||
                input1[0] < 'a' || input1[0] > 'h' || input1[1] < '1' || input1[1] > '8' ||
                input2[0] < 'a' || input2[0] > 'h' || input2[1] < '1' || input2[1] > '8')
            {
                Console.WriteLine("Введены некорректные координаты.");
                return;
            }

            // Получение координат полей.
            char field1Column = input1[0];
            int field1Row = int.Parse(input1[1].ToString());
            char field2Column = input2[0];
            int field2Row = int.Parse(input2[1].ToString());

            // Проверка, являются ли поля одного цвета.
            

            // Вывод результата.
            if ((field1Column % 2 == field1Row % 2) && (field2Column % 2 == field2Row % 2))
            {
                Console.WriteLine("Поля {0} и {1} являются полями одного цвета.", input1, input2);
            }
            else
            {
                Console.WriteLine("Поля {0} и {1} являются полями разного цвета.", input1, input2);
            }
        }
    }
}
