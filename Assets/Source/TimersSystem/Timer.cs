using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Source.TimersSystem
{
    internal sealed class Timer : ITimer
    {
        private const int SecondsInMinutes = 60;
        
        private bool _canUpdate;
        private float _time;

        public Timer(float time)
        {
            _time = time;
        }

        public int Seconds { get; private set; }
        public int Minutes { get; private set; }
        
        public void Start()
        {
            _canUpdate = true;
        }

        public void Update(float deltaTime)
        {
            if (_canUpdate == false)
                return;

            _time -= deltaTime;

            Seconds = (int)_time;
            Minutes = Seconds / SecondsInMinutes;
        }

        public void Stop()
        {
            _canUpdate = false;
        }
    }
}