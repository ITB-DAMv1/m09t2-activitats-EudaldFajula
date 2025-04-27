using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2Activitats
{
    public  class Ex2_3
    {
        public static void MainEx23()
        {
            //Ex 2
            string fileRouteEx2 = "../../../processList.txt";
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "dotnet",
                    Arguments = "--info",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();

            string output = process.StandardOutput.ReadToEnd();
            process.WaitForExit();
            Console.WriteLine(output);

            var processos = Process.GetProcesses();
            using (StreamWriter escriptor = new StreamWriter(fileRouteEx2))
            {
                foreach (Process os in processos)
                {
                    Console.WriteLine($"PID: {os.Id}, Name: {os.ProcessName}");
                    escriptor.WriteLine($"PID: {os.Id}, Name: {os.ProcessName}");
                }
            }

            //Ex 3
            string fileRouteEx3 = "../../../one_process.txt";
            Console.WriteLine("Choose a process: (PID)");
            int pid = int.Parse(Console.ReadLine());
            Process chromeP = null;
            try
            {
                chromeP = Process.GetProcessById(pid);
                ProcessThreadCollection pTC = chromeP.Threads;
                Console.WriteLine("Threats of the program {0}, Threats count: {1}", chromeP.ProcessName, pTC.Count);
                using (StreamWriter escriptor = new StreamWriter(fileRouteEx3))
                {
                    foreach (ProcessThread pt in pTC)
                    {
                        Console.WriteLine($"{pt.Id} \t Container {pt.Container}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            try
            {
                ProcessModuleCollection pMC = chromeP.Modules;
                Console.WriteLine("Modul of the program {0}, ModulCount: {1}", chromeP.ProcessName, pMC.Count);
                using (StreamWriter escriptor = new StreamWriter(fileRouteEx3))
                {
                    foreach (ProcessModule pM in pMC)
                    {
                        Console.WriteLine($"{pM.ModuleName} \t Container: {pM.Container}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
