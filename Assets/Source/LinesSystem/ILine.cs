using System;

namespace Source.LinesSystem
{
    public interface ILine
    {
        event Action Completed;
        
        int Sum { get; }
        bool IsCompleted { get; }

        void Activate();
        void Deactivate();
    }
}