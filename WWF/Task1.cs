using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWF
{
    public class MyException : Exception
    {
        public override string Message { get; } = "MyException";
    }
    internal class Exception1
    {
        public static void Task1()
        {
            Exception[] exceptions = [
                new DivideByZeroException(), new ArgumentNullException(),
                new IndexOutOfRangeException(), new OverflowException(),
                new MyException()
                ];
            foreach (var ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (AbandonedMutexException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.Write(e.Message);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
