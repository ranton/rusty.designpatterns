namespace Rusty.DesignPatterns.Builder.CPUBuild
{
    public abstract class CPUBuilder : Builder<CPU>
    {
        public abstract CPUBuilder AddProcessor(Processor processor);
        public abstract CPUBuilder AddVideoCard(VideoCard videoCard);
    }
}