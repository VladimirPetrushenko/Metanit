using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            For2Million.getStopAsync();
            ForMillion.getStopAsync();

            Console.ReadLine();
        }


        public class ForMillion
        {
            public static void getStop()
            {
                int m = 0;
                for (int i = 0; i < 1_000_000_000; i++)
                {
                   m = i*i;
                }
                Console.WriteLine(m);
            }

            public static async void getStopAsync()
            {
                await Task.Run(() => getStop());
            }
        }
        public class For2Million
        {
            public static void getStop()
            {
                int m = 0;
                for (int i = 0; i < 2_000_000_000; i++)
                {
                    m = i*i;
                }
                Console.WriteLine(m);
            }

            public static async void getStopAsync()
            {
                await Task.Run(() => getStop());
            }
        }
    }
}
