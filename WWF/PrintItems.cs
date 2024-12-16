using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace WWF
{
    internal class PrintItems
    {
        public static void ConfirmDeleting(List<string> filesForDeleting)
        {

            var selectedVariant = 0;

            while (true)
            {
                Console.Clear();
                PrintItems.PrintItemsForDeleting(filesForDeleting);
                PrintItems.PrintYesNo(selectedVariant);

                var key = Console.ReadKey().Key;

                if (key == ConsoleKey.RightArrow)
                    selectedVariant = 2;

                if (key == ConsoleKey.LeftArrow)
                    selectedVariant = 1;


                if (key == ConsoleKey.Enter)
                {
                    if (selectedVariant == 1)
                        PrintItemsForDeleting(filesForDeleting);
                }
                else
                {
                    break;
                }

            }

        }

        public static void PrintItemsForDeleting(List<string> filesForDeleting)
        {
            Console.WriteLine("Будут удалены следуюшие файлы: ");

            foreach (var files in filesForDeleting)
            {
                Console.WriteLine(files);
            }

        }
        public static void PrintYesNo(int slelectedVariant)
        {
            Console.WriteLine("Вы точно хотите продолжить?");

            if (slelectedVariant == 0)
            {
                Console.WriteLine("  YES ");
                Console.WriteLine();
                Console.WriteLine("  NO  ");
            }

            if (slelectedVariant == 1)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("  YES ");
                Console.WriteLine();
                Console.ResetColor();
                Console.WriteLine("  NO  ");

            }
            if (slelectedVariant == 2)
            {
                Console.WriteLine("  YES ");
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("  NO  ");
                Console.ResetColor();

            }
        }

    }
}
