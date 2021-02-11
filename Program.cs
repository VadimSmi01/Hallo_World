using System;


namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string eS = "Hello world";
            int ei = 50;
            bool eb = true; //true/false
            char ech = 'n'; //только 1 символ
            Console.WriteLine(eS);
            string[] hellos = { "Hallo", "Hello", "Salve", "Ciao" };
            Console.WriteLine(hellos[0]);
            Console.WriteLine(hellos[3]);

            Console.WriteLine(eS);
            //for (int i = 0; i < hellos.Length; i++)
            int i = 0;
            foreach (string hello in hellos)
            {
                Console.WriteLine(hello);
                i++;
                Console.WriteLine("You have continued " + i + " times");
            }

            ech = Console.ReadLine()[0];
            switch (ech)
            {
                case 'n':
                    Console.WriteLine("Its N");
                    break;

                case 't':
                    Console.WriteLine("Its T");
                    break;

                case 'b':
                    Console.WriteLine("Its B");
                    break;

                default:
                    Console.WriteLine("It is not any of known symbols.");
                    break;

            }
            /*
        if (Console.ReadKey().Key == ConsoleKey.N)
        {
            Console.WriteLine("\nВы продолжили.");
            Console.ReadKey();
        }
        else
        {
            Console.WriteLine("\nБла бла бла");
            Console.ReadKey();
        }
    }
            */

        }
    }
}