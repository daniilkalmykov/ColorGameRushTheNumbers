using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Source.CellsSystem
{
    internal sealed class Cell : ICell
    {
        private const int MaxNumber = 5;

        public Cell(uint startNumber)
        {
            CurrentNumber = (int)startNumber;
        }
        
        public event Action Tapped;

        public int CurrentNumber { get; private set; }
        
        public void Tap()
        {
            CurrentNumber++;

            if (CurrentNumber > MaxNumber)
                CurrentNumber = 1;

            Tapped?.Invoke();
        }
    }
}