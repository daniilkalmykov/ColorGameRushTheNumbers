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
        private ICell _cell;

        public override void Compose()
        {
            _cellButton = GetComponent<CellButton>();
            
            _cell = new Cell();
            
            _cellText.Init(_cell);
            _cellButton.Init(_cell);
            
            _cellText.Show();
        }
    }
}