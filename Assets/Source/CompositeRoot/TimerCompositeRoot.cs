using Source.TimersSystem;

namespace Source.CompositeRoot
{
    internal sealed class TimerCompositeRoot : CompositeRoot
    {
        public ITimer Timer { get; private set; }
        
        public override void Compose()
        {
            Timer = new Timer();
        }
    }
}