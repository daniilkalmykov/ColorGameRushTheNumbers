using System;

namespace Source.LinesSystem
{
    public interface ILine
    {
        event Action Completed;
        
        int Sum { get; }

        void Activate();
        void Deactivate();
    }
}