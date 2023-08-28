using System;

namespace Source.LinesSystem
{
    public interface ILine
    {
        event Action Completed;

        bool IsCompleted { get; }
    }
}