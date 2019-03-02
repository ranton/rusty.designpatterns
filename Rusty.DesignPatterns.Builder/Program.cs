using System;
using Rusty.DesignPatterns.Builder.CPUBuild;

namespace Rusty.DesignPatterns.Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            var gamingCpu = new GamingCPUBuilder()
                .AddProcessor(new QuadCoreProcessor())
                .AddVideoCard(new GeForceGtxVideoCard())
                .Build();
            
            Console.WriteLine(gamingCpu.ToString());

            Console.WriteLine("---------------------------------");

            var officeCPU = new OfficeCPUBuilder()
                .AddProcessor(new DualCoreProcessor())
                .AddVideoCard(new ZotacVideoCard())
                .Build();
            Console.WriteLine(officeCPU.ToString());
            Console.ReadLine();
        }
    }
}
