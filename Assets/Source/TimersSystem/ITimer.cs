namespace Source.TimersSystem
{
    public interface ITimer
    {
        int Seconds { get; }
        int Minutes { get; }

        void Start();
        void Update(float deltaTime);
        void Stop();
    }
}