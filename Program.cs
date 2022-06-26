using System;

namespace Laba3
{
    class Program
    {
        static void Main()
        {
            int mode = 0;
            while (mode != 1)
            {
                Console.Write("Чтобы выбрать задание нажмите [1], [2] или [3]. Для выхода из программы нажмите [4]: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        mode = 0;
                        Task1.First();
                        break;

                    case 2:
                        mode = 0;
                        Task2.Second();
                        break;

                    case 3:
                        mode = 0;
                        Task3.Third();
                        break;

                    case 4:
                        mode = 1;
                        Console.WriteLine("\nДо побачення!");
                        break;

                    default:
                        mode = 0;
                        Console.WriteLine("\nПоздравляем, вы всё сломали!\nПопробуем снова?\n");
                        break;
                }
            }
        }
    }
}

