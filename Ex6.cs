using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2Activitats
{
    public class Camel
    {
        private int Id;
        private int MinSleep, MaxSleep;

        public Camel(int id, int minSleep, int maxSleep)
        {
            Id = id;
            MinSleep = minSleep;
            MaxSleep = maxSleep;
        }

        public void Run()
        {
            var rand = new Random(Guid.NewGuid().GetHashCode());
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine($"Camell {Id}: {i}");
                int ms = rand.Next(MinSleep, MaxSleep + 1);
                Thread.Sleep(ms);
            }
        }
    }
    public class Ex6
    {
        public static void Main()
        {
            var camells = new Thread[5];
            for (int i = 0; i < 5; i++)
            {

                int min = 10 + i * 5;
                int max = min + 20;
                var c = new Camel(i + 1, min, max);
                camells[i] = new Thread(c.Run);
            }

            foreach (var t in camells) t.Start();
            foreach (var t in camells) t.Join();

            Console.WriteLine("Carrera acabada!");
        }
    }
}
