using System;
namespace SomeConsoleApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Console.WriteLine(random.Next());
            
            var iAmTrue = AlwaysReturnsTrue();
            if (iAmTrue)
            {
                Console.WriteLine("true");
            }

            Console.ReadKey();
        }

        private const  bool _alwaysTrue = true;
        public static bool AlwaysReturnsTrue()
        {
            return _alwaysTrue;
        }


        public static object Passthrough(object obj)
        {
            return obj;
        }
    }
}
