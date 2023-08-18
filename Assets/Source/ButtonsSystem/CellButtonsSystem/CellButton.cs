using System;
using System.Runtime.CompilerServices;
using Source.CellsSystem;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Source.ButtonsSystem.CellButtonsSystem
{
    internal sealed class CellButton : GameButton
    {
        private ICell _cell;

        public void Init(ICell cell)
        {
            _cell = cell ?? throw new ArgumentNullException();
        }
        
        protected override void OnClick()
        {
            _cell?.Tap();
        }
    }
}