using System.Security.Cryptography.X509Certificates;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Salom \n ");         
            Console.Write(" Enter number : ");         
            int num = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor= ConsoleColor.White;

            Thread thread = new Thread(() => PrintNum(num));

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