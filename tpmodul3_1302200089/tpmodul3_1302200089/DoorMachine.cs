using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul3_1302200089
{
    internal class DoorMachine
    {
        enum State { terkunci, terbuka, exit };

        public static void Mulai()
        {

            Console.WriteLine("Pintu terkunci");
            //Console.WriteLine("\n");
            State state = State.terkunci;
            while (state != State.exit)
            {
                Console.Write("State -> ");
                string command = Console.ReadLine();
                switch (command)
                {
                    case "terkunci":
                        Console.WriteLine("Pintu terkunci");
                        Console.WriteLine();
                        state = State.terkunci;
                        break;
                    case "terbuka":
                        Console.WriteLine("Pintu tidak terkunci");
                        Console.WriteLine();
                        state = State.terbuka;
                        break;
                    case "exit":
                        state = State.exit;
                        Console.WriteLine("Keluar dari program!");
                        break;
                    default:
                        Console.WriteLine("Masukan ulang State");
                        Console.WriteLine("\n");
                        break;
                }
            }

        }
    }
}
