using System;

namespace Source.CellsSystem
{
    public interface ICell
    {
        event Action Tapped;
        
        int CurrentNumber { get; }

        void Tap();
    }
}