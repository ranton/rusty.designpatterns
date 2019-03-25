namespace Rusty.DesignPatterns.Bridge
{
    public class FortySixInchesTelevision : Television
    {
        public override void ShowDisplay(ITelevisionDisplayer displayer)
        {
            displayer.Display(46.0m);
        }
    }
}