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

        public Line(List<ICell> cells, uint sum)
        {
            _cells = cells ?? throw new ArgumentNullException();
            Sum = (int)sum;
        }

        public event Action Completed;
        
        public int Sum { get; }
        
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
            if (_cells.Sum(cell => cell.CurrentNumber) == Sum)
                Completed?.Invoke();
        }
    }
}