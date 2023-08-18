using Source.ButtonsSystem.CellButtonsSystem;
using Source.CellsSystem;
using Source.TextsSystem.CellTextsSystem;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(CellButton))]
    internal sealed class CellCompositeRoot : CompositeRoot
    {
        [SerializeField] private CellText _cellText;
        
        private CellButton _cellButton;
        
        public Cell Cell { get; private set; }

        public override void Compose()
        {
            _cellButton = GetComponent<CellButton>();
            
            Cell = new Cell();
            
            _cellText.Init(Cell);
            _cellButton.Init(Cell);
            
            _cellText.Show();
        }
    }
}