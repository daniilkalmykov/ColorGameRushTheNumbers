using System;
using System.Collections.Generic;
using Source.ButtonsSystem;
using Source.CellsSystem;
using Source.TextsSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(CellButton))]
    internal sealed class CellCompositeRoot : CompositeRoot
    {
        [SerializeField] private GameText _number;
        [SerializeField] private List<Image> _images;
        
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
            _number.Init();
            
            SetCell();

            Cell.Tapped += OnTapped;
        }

        private void OnTapped()
        {
            SetCell();
        }

        private void SetCell()
        {
            _cellButton.SetImage(_images[Cell.CurrentNumber]);
            _number.Show(Cell.CurrentNumber.ToString());
        }
    }
}