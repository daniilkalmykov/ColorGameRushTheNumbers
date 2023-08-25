using System;
using System.Collections.Generic;
using System.Linq;
using Source.LinesSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(Image))]
    internal sealed class LineCompositeRoot : CompositeRoot
    {
        [SerializeField] private List<CellCompositeRoot> _cellCompositeRoots;

        private uint _sum;
        private Image _image;
        private Sprite _sprite;

        public Line Line { get; private set; }

        public void Init(uint sum, Sprite sprite)
        {
            _sum = sum;
            _sprite = sprite;
        }

        public override void Compose()
        {
            _image = GetComponent<Image>();
            
            var cells = _cellCompositeRoots.Select(cellCompositeRoot => cellCompositeRoot.Cell).ToList();

            Line = new Line(cells, _sum);

            _image.sprite = _sprite;
        }
    }
}