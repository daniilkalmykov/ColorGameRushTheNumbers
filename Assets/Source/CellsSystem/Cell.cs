using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Source.CellsSystem
{
    internal sealed class Cell : ICell
    {
        private const int MaxNumber = 5;

        public event Action Tapped;

        public int CurrentNumber { get; private set; } = 1;

        public void Tap()
        {
            CurrentNumber++;

            if (CurrentNumber > MaxNumber)
                CurrentNumber = 1;

            Tapped?.Invoke();
        }
    }
}