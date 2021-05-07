using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Cognome_Semaforo_Bin
{
    class Program
    {
        static int n;
        static void Main(string[] args)
        {
            while(true)
            {
                n = 0;
                Thread t1 = new Thread(() => Incrementa());
                Thread t2 = new Thread(() => Decrementa());
                t1.Start();
                t2.Start();
                while(t1.IsAlive) { }
                while(t2.IsAlive) { }
                Console.WriteLine($"n = {n}");
                Console.ReadLine();
            }
        }

        public static void Incrementa()
        {
            for(int i = 0; i <= 1000000; i++)
            {
                n++; 
            }
        }

        public static void Decrementa()
        {
            for (int i = 0; i <= 1000000; i++)
            {
                n--;
            }
        }
    }
}
