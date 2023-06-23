namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the your number:");
            int number = int.Parse(Console.ReadLine());
            Thread thread = new Thread(() => { PrimeNumber(number); });

            Thread thread1 = new Thread(() => { EvenNumber(number); });

            thread.Start();
            thread1.Start();



        }
        static void PrimeNumber(int number)
        {
            string filePath = Path.Combine(@"C:\3-modul\", "Thread1.txt");
            if (File.Exists(filePath))
            {
                Console.WriteLine("Accaount already created!");
            }
            else
            {
                File.Create(filePath).Close();
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    for (int i = 1; i < number; i += 2)
                    {
                        Console.WriteLine(i);
                        writer.WriteLine(i);
                    }


                }
                Console.WriteLine("Account created successfully");
            }

        }
        static void EvenNumber(int number)
        {
            string filePath = Path.Combine(@"C:\3-modul\", "Thread2.txt");

            using (StreamWriter writer = new StreamWriter(filePath))
            {

                for (int i = 2; i < number; i += 2)
                {
                    Console.WriteLine(i);
                    writer.WriteLine(i);
                }

            }


        }
    }
}