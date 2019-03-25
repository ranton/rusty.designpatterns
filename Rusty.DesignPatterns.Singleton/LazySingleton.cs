using System;

namespace Rusty.DesignPatterns.Singleton
{
    public sealed class LazySingleton
    {
        private static readonly Lazy<LazySingleton>
            lazy =
                new Lazy<LazySingleton>
                    (() => new LazySingleton());

        public static LazySingleton Instance => lazy.Value;

        private LazySingleton()
        {
        }
    }
}