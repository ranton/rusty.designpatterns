namespace Rusty.DesignPatterns.Builder.CPUBuild
{
    public class GamingCPUBuilder : CPUBuilder
    {
        private readonly CPU _product = new GamingCPU();


        public override CPUBuilder AddProcessor(Processor processor)
        {
            this._product.Processor = processor;
            return this;
        }

        public override CPUBuilder AddVideoCard(VideoCard videoCard)
        {
            this._product.VideoCard = videoCard;
            return this;
        }


        public override CPU Build()
        {
            return this._product;
        }
    }
}