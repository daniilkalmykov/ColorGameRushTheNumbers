
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Lil_biba.ColorGameRushTheNumbers.TimersSystem")]
namespace Source.TimersSystem
{
    internal sealed class Timer : ITimer
    {
        private const int SecondsInMinutes = 60;
        
        private bool _canUpdate;
        private float _time;
        
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

            _time += deltaTime;

            if (_time >= 1)
            {
                Seconds++;
                _time = 0;
            }

            if (Seconds >= SecondsInMinutes)
                Minutes++;
        }

        public void Stop()
        {
            _canUpdate = false;
        }
    }
}