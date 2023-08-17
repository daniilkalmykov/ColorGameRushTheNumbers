using Source.CellsSystem;

namespace Source.ButtonsSystem.CellButtonsSystem
{
    internal sealed class CellButton : GameButton, ICellButton
    {
        private ICell _cell;

        public void Init(ICell cell)
        {
            _cell = cell;
        }
        
        protected override void OnClick()
        {
            _cell?.Tap();
        }
    }
}