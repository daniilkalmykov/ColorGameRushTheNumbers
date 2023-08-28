using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Source.LinesSystem;
using Source.Wallet;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Source.LevelsSystem
{
    internal sealed class Level
    {
        private readonly List<ILine> _lines;
        private readonly IWallet _wallet;
        private readonly uint _prize;

        private int _ends;
        
        public Level(List<ILine> lines, IWallet wallet, uint prize)
        {
            _lines = lines ?? throw new ArgumentNullException();
            _wallet = wallet ?? throw new ArgumentNullException();
            _prize = prize;
        }

        public event Action Ended;

        public void Start()
        {
            foreach (var line in _lines)
                line.Completed += OnCompleted;
        }

        public void Update()
        {
            if (_lines.All(line => line.IsCompleted) == false || _ends != 0)
                return;
            
            _ends++;
            
            End();
        }      
        
        private void End()
        {
            foreach (var line in _lines)
                line.Completed -= OnCompleted;

            _wallet.AddMoney((int)_prize);
            
            Ended?.Invoke();
        }

        private void OnCompleted()
        {
            if (_lines.All(line => line.IsCompleted))
                End();
        }
    }
}