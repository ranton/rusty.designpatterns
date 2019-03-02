using System;

namespace Rusty.DesignPatterns.Builder.CPUBuild
{
    public class OfficeCPUBuilder : CPUBuilder
    {
        private CPU _product = new OfficeCPU();


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