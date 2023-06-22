using System.Security.Cryptography.X509Certificates;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Salom ");
            Console.ForegroundColor= ConsoleColor.White;

            Thread thread = new Thread(() => PrintNum(23));

            thread.Start();
            
            void PrintNum(int Num)
            {
                for (int i = 1; i <= Num; i++) 
                {
                    Console.WriteLine($"Thread Name : {i} \n ");
                }
            }
        }
    }
}