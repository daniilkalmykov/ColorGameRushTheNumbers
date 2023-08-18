using System;
using Source.CellsSystem;
using UnityEngine;

namespace Source.TextsSystem.CellTextsSystem
{
    internal sealed class CellText : GameText
    {
        [SerializeField] private string _startText;
        
        private ICell _cell;

        private void OnDisable()
        {
            if (_cell != null)
                _cell.Tapped -= OnTapped;
        }

        private void Start()
        {
            Text.text = _startText;
        }

        public void Init(ICell cell)
        {
            _cell = cell ?? throw new ArgumentNullException();

            _cell.Tapped += OnTapped;
        }

        private void OnTapped()
        {
            Text.text = _cell.CurrentNumber.ToString();
        }
    }
}