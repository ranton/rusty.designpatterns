namespace Rusty.DesignPatterns.Bridge
{
    public class ThirtyTwoInchesTelevision : Television
    {
        public override void ShowDisplay(ITelevisionDisplayer displayer)
        {
            displayer.Display(32.0m);
        }
    }
}