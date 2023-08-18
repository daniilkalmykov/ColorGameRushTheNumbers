using Source.ButtonsSystem.CellButtonsSystem;
using Source.CellsSystem;
using Source.TextsSystem;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(CellButton))]
    internal sealed class CellCompositeRoot : CompositeRoot
    {
        [SerializeField] private GameText _number;
        
        private CellButton _cellButton;
        
        public ICell Cell { get; private set; }

        private void OnDisable()
        {
            if (Cell != null)
                Cell.Tapped -= OnTapped;
        }

        public override void Compose()
        {
            _cellButton = GetComponent<CellButton>();
            
            Cell = new Cell();
            
            _cellButton.Init(Cell);
            _number.Show(Cell.CurrentNumber.ToString());

            Cell.Tapped += OnTapped;
        }

        private void OnTapped()
        {
            _number.Show(Cell.CurrentNumber.ToString());
        }
    }
}