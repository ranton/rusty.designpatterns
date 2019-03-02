namespace Rusty.DesignPatterns.Builder.CPUBuild
{
    public class GamingCPU : CPU
    {
        public override string ToString()
        {
            return $"Processor: {this.Processor.GetType().Name}, VideoCard: {this.VideoCard.GetType().Name}";
        }
    }
}