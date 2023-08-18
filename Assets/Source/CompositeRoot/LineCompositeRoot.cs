using System.Collections.Generic;
using System.Linq;
using Source.LinesSystem;
using Source.TextsSystem;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(GameText))]
    internal sealed class LineCompositeRoot : CompositeRoot
    {
        [SerializeField] private List<CellCompositeRoot> _cellCompositeRoots;
        [SerializeField] private uint _sum;

        private GameText _text;
        
        public Line Line { get; private set; }

        private void Awake()
        {
            _text = GetComponent<GameText>();
        }

        public override void Compose()
        {
            var cells = _cellCompositeRoots.Select(cellCompositeRoot => cellCompositeRoot.Cell).ToList();

            Line = new Line(cells, _sum);

            _text.Show(Line.Sum.ToString());
        }
    }
}