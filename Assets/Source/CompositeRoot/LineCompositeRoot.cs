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

        private GameText _text;
        private uint _sum;
        
        public Line Line { get; private set; }

        public void Init(uint sum)
        {
            _sum = sum;
        }

        public override void Compose()
        {
            var cells = _cellCompositeRoots.Select(cellCompositeRoot => cellCompositeRoot.Cell).ToList();

            Line = new Line(cells, _sum);
            
            _text = GetComponent<GameText>();
            
            _text.Init();
            _text.Show(Line.Sum.ToString());
        }
    }
}