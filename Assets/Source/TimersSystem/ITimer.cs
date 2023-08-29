using System;

namespace Source.TimersSystem
{
    public interface ITimer
    {
        event Action Ended;
        
        int Seconds { get; }
        int Minutes { get; }

        void Start();
        void Update(float deltaTime);
        void Stop();
    }
}