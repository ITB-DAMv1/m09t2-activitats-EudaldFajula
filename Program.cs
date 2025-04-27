using System.Diagnostics;

namespace T2Activitats
{
    public class Program
    {
        public static void Main()
        {
            var processos = Process.GetProcesses();
            using (var writer = new StreamWriter("processos.txt"))
            {
                foreach (var p in processos)
                {
                    string info = $"{p.ProcessName} - PID: {p.Id}";
                    Console.WriteLine(info);
                    writer.WriteLine(info);
                }
            }
            Console.WriteLine("Llista de processos desada a processos.txt");
        }
    }

}
