using System.Collections.Generic;
using System.Linq;
using Source.LinesSystem;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class LineCompositeRoot : CompositeRoot
    {
        [SerializeField] private List<CellCompositeRoot> _cellCompositeRoots;
        [SerializeField] private uint _sum;

        public Line Line { get; private set; }

        public override void Compose()
        {
            var cells = _cellCompositeRoots.Select(cellCompositeRoot => cellCompositeRoot.Cell).ToList();

            Line = new Line(cells, _sum);
        }
    }
}