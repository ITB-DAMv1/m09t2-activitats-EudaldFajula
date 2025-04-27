using System.Diagnostics;

namespace T2Activitats
{
    public class Program
    {
        public static void Main()
        {
            //Ex5a
            Thread[] threadsEx5a = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                int num = i + 1;
                threadsEx5a[i] = new Thread(() =>
                {
                    Console.WriteLine($"Hola! Sóc el fil número {num}");
                });
            }
            foreach (var t in threadsEx5a) { t.Start(); }

            foreach (var t in threadsEx5a) { t.Join(); }

            //Ex5b
            Thread[] threadsEx5b = new Thread[5];
            for (int i = 0; i < 5; i++)
            {
                int num = i + 1;
                threadsEx5b[i] = new Thread(() =>
                {
                    Thread.Sleep((6 - num) * 100);
                    Console.WriteLine($"Hola! Soc el fil número {num}");
                });
            }

            foreach (var t in threadsEx5b) { t.Start(); }

            foreach (var t in threadsEx5b) { t.Join(); }
        }

    }

}
