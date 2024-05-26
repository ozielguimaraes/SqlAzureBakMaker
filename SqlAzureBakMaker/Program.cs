using System;
using System.Diagnostics;

namespace SqlAzureBakMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            var parms = new MyArgs();// Args.Parse<MyArgs>(args);

            Console.WriteLine("Starting");
            var sw = new Stopwatch();
            sw.Start();
            BackupMaker.CopyDatabase(parms);
            sw.Stop();
            Console.WriteLine($"Done in {sw.Elapsed.TotalMinutes:N} minutes");
            Console.ReadKey();
        }
    }
}
