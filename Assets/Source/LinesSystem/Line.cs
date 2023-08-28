using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Source.CellsSystem;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Source.LinesSystem
{
    internal sealed class Line : ILine
    {
        private readonly List<ICell> _cells;
        private readonly int _sum;

        public Line(List<ICell> cells, uint sum)
        {
            _cells = cells ?? throw new ArgumentNullException();
            _sum = (int)sum;
        }

        public event Action Completed;

        public bool IsCompleted { get; private set; }

        public void Activate()
        {
            foreach (var cell in _cells)
                cell.Tapped += OnTapped;
        }

        public void Deactivate()
        {
            foreach (var cell in _cells)
                cell.Tapped -= OnTapped;
        }

        private void OnTapped()
        {
            if (_cells.Sum(cell => cell.CurrentNumber) == _sum)
            {
                Completed?.Invoke();
                IsCompleted = true;
            }
            else
            {
                IsCompleted = false;
            }
        }
    }
}