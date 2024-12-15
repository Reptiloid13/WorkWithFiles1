using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWf2;

public class InvalidSortVariantException : Exception
{
    public override string Message { get; } = "Сортировку можно задать либо чилос 1 ( по возрастанию ), либо чилсом 2 (по убыванию)";
}
internal class Exception2
{
    public delegate void PrintSortedNamesAscDelegate(List<string> names);
    public delegate void PrintSortedNamesDescDelegate(List<string> names);

    public static event PrintSortedNamesAscDelegate PrintSortedNamesAscEvent;
    public static event PrintSortedNamesDescDelegate PrintSortedNamesDescEvent;

    public static void Task2()
    {
        var names = new List<string> { "Don Jhons", "Evgen Petrenko", "Artur Isaev", "Bob Dylan", "Carl Varvorovich" };
        Console.WriteLine("Введите 1, чтобы отсортировать по возрастанию и 2, чтобы по убыванию ");

        PrintSortedNamesDescEvent += PrintSortedNamesDesc;
        PrintSortedNamesAscEvent += PrintSortedNamesAsc;

        try
        {
            var variant = int.Parse(Console.ReadLine());
            if (variant != 1 && variant != 2) throw new InvalidSortVariantException();

            if (variant == 1)
            {
                PrintSortedNamesAscEvent(names);
            }
            else if (variant == 2)
            {
                PrintSortedNamesDescEvent(names);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }


    }


    public static void PrintSortedNamesAsc(List<string> names)
    {
        names.Sort();
        Console.WriteLine(string.Join(", ", names));
    }
    public static void PrintSortedNamesDesc(List<string> names)
    {
        names.Sort();
        names.Reverse();
        Console.WriteLine(string.Join(",", names));
    }



}
