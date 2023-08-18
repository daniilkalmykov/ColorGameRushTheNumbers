using System.Collections.Generic;
using System.Linq;
using Source.LinesSystem;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class LineCompositeRoot : CompositeRoot
    {
        [SerializeField] private uint _sum;
        [SerializeField] private List<CellCompositeRoot> _cellCompositeRoots;

        private Line _line;
        
        public override void Compose()
        {
            var cells = _cellCompositeRoots.Select(cellCompositeRoot => cellCompositeRoot.Cell).ToList();

            _line = new Line(cells, _sum);
        }
    }
}