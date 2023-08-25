using System.Collections.Generic;
using Source.ButtonsSystem;
using Source.CellsSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(CellButton))]
    internal sealed class CellCompositeRoot : CompositeRoot
    {
        [SerializeField] private List<Sprite> _sprites;
        
        private CellButton _cellButton;
        private Image _image;

        public ICell Cell { get; private set; }

        private void OnDisable()
        {
            if (Cell != null)
                Cell.Tapped -= OnTapped;
        }

        public override void Compose()
        {
            _image = GetComponent<Image>();
            _cellButton = GetComponent<CellButton>();

            Cell = new Cell();
            
            _cellButton.Init(Cell);
            
            SetCell();

            Cell.Tapped += OnTapped;
        }

        private void OnTapped()
        {
            SetCell();
        }

        private void SetCell()
        {
            _image.sprite = _sprites[Cell.CurrentNumber - 1];
        }
    }
}