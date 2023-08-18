using System;
using System.Collections.Generic;
using System.Linq;
using Source.LinesSystem;

namespace Source.LevelsSystem
{
    internal sealed class Level
    {
        private readonly List<ILine> _lines;

        public Level(List<ILine> lines)
        {
            _lines = lines ?? throw new ArgumentNullException();
        }

        public void Start()
        {
            foreach (var line in _lines)
                line.Completed += OnCompleted;
        }

        private void End()
        {
            foreach (var line in _lines)
                line.Completed -= OnCompleted;
        }

        private void OnCompleted()
        {
            if (_lines.All(line => line.IsCompleted))
                End();
        }
    }
}