using System;

namespace Programm
{
    class PianoApp
    {
        static int[] Perva = new int[] { 130, 138, 146, 155, 164 };
        static int[] Vtora = new int[] { 261, 277, 293, 311, 392 };

        static int Ockt = 1;
        static void Main()
        {
            Console.WriteLine("Переключение между Октавами F1-F2");
            ConsoleKey key = Console.ReadKey().Key;

            do
            {
                if(key == ConsoleKey.F1)
                {
                    Console.WriteLine("Октава 2");
                    Ockt = 1;
                    SelectedSound(key);
                }
                if(key == ConsoleKey.F2)
                {
                    Console.WriteLine("Октава 3");
                    Ockt = 2;
                    SelectedSound(key);
                }

                key = Console.ReadKey().Key;
                SelectedSound(key);
                Console.Clear();
            }
            while(key != ConsoleKey.Escape);
        }

        public static void SelectedSound(ConsoleKey bind)
        {
            try
            {
                switch(bind)
                {
                    case ConsoleKey.Q:
                        if(Ockt == 1)
                        {
                            Console.Beep(Perva[0], 350);
                        }
                        if (Ockt == 2)
                        {
                            Console.Beep(Vtora[0], 350);
                        }
                        break;
                    case ConsoleKey.W:
                        if (Ockt == 1)
                        {
                            Console.Beep(Perva[1], 350);
                        }
                        if (Ockt == 2)
                        {
                            Console.Beep(Vtora[1], 350);
                        }
                        break;
                    case ConsoleKey.E:
                        if (Ockt == 1)
                        {
                            Console.Beep(Perva[2], 350);
                        }
                        if (Ockt == 2)
                        {
                            Console.Beep(Vtora[2], 350);
                        }
                        break;
                    case ConsoleKey.R:
                        if (Ockt == 1)
                        {
                            Console.Beep(Perva[3], 350);
                        }
                        if (Ockt == 2)
                        {
                            Console.Beep(Vtora[3], 350);
                        }
                        break;
                    case ConsoleKey.T:
                        if (Ockt == 1)
                        {
                            Console.Beep(Perva[4], 350);
                        }
                        if (Ockt == 2)
                        {
                            Console.Beep(Vtora[4], 350);
                        }
                        break;
                    case ConsoleKey.Y:
                        if (Ockt == 1)
                        {
                            Console.Beep(Perva[4], 350);
                        }
                        if (Ockt == 2)
                        {
                            Console.Beep(Vtora[4], 350);
                        }
                        break;
                }
            }
            catch (Exception ex) { }
        }
    }
    
}