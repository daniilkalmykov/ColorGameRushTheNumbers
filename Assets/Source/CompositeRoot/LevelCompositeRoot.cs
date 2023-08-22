using System;
using System.Collections.Generic;
using System.Linq;
using Source.LevelsSystem;
using Source.LinesSystem;
using Source.Wallet;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class LevelCompositeRoot : CompositeRoot
    {
        [SerializeField] private List<LineCompositeRoot> _lineCompositeRoots;

        private Level _level;
        private uint _prize;
        private IWallet _wallet;

        public void Init(uint prize, IWallet wallet)
        {
            if (prize <= 0)
                throw new ArgumentException();

            _prize = prize;
            _wallet = wallet ?? throw new ArgumentNullException();
        }
        
        public override void Compose()
        {
            var lines = _lineCompositeRoots.Select(lineCompositeRoot => lineCompositeRoot.Line).Cast<ILine>().ToList();

            _level = new Level(lines, _wallet, _prize);
            
            _level.Start();
        }
    }
}