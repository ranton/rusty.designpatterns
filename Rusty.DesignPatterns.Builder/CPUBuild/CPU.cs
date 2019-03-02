namespace Rusty.DesignPatterns.Builder.CPUBuild
{
    public abstract class CPU
    {
        public Processor Processor { get; set; }
        public VideoCard VideoCard { get; set; }
       
    }
}