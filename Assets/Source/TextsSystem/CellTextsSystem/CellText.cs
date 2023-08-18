using System;
using Source.CellsSystem;

namespace Source.TextsSystem.CellTextsSystem
{
    internal sealed class CellText : GameText
    {
        private ICell _cell;

        private void OnDisable()
        {
            if (_cell != null)
                _cell.Tapped -= OnTapped;
        }

        public void Init(ICell cell)
        {
            _cell = cell ?? throw new ArgumentNullException();

            _cell.Tapped += OnTapped;
        }

        public void Show()
        {
            Text.text = _cell.CurrentNumber.ToString();
        }
        
        private void OnTapped()
        {
            Show();
        }
    }
}