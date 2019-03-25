namespace Rusty.DesignPatterns.Singleton
{
    public class Singleton
    {
        private static readonly Singleton _instance = new Singleton();

        public static Singleton Instance => _instance;
    }
}