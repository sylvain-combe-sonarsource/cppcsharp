using System;
namespace SomeConsolePrints
{
    public class Program
    {
        static void Main(string[] args)
        {
            var iAmTrue = AlwaysReturnsTrue(); //true;
            if (iAmTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Console.ReadKey();
        }

        // orig for Sonar rule check
        public static bool AlwaysReturnsTrue()
        {
            return true;
        }

        //private const  bool _alwaysTrue = true;
        //public static bool AlwaysReturnsTrue()
        //{
        //    return _alwaysTrue;
        //}


        public static object Passthrough(object obj)
        {
            return obj;
        }
    }
}
