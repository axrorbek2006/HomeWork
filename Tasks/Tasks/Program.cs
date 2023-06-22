namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Salom \n ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Enter number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" \n Even nums \n ");
            Console.ForegroundColor = ConsoleColor.White;

            Thread thread1 = new Thread(() => PrintEvenNum(num));
            Thread thread2 = new Thread(() => PrintOddNum(num));

            thread1.Start();

            thread2.Start();


            void PrintEvenNum(int num ) 
            {
                for (int i = 1; i <= num; i++) 
                { 
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i+"\n");
                    }
                }

                
            }

            void PrintOddNum(int num)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" \n Odd nums \n ");
                Console.ForegroundColor = ConsoleColor.White;
                for (int i = 1; i <= num; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i + "\n");
                    }
                }
            }
        }
    }
}