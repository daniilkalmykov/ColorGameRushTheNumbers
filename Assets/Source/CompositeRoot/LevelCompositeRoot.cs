using System.Collections.Generic;
using System.Linq;
using Source.LevelsSystem;
using Source.LinesSystem;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class LevelCompositeRoot : CompositeRoot
    {
        [SerializeField] private List<LineCompositeRoot> _lineCompositeRoots;

        private Level _level;

        public override void Compose()
        {
            var lines = _lineCompositeRoots.Select(lineCompositeRoot => lineCompositeRoot.Line).Cast<ILine>().ToList();

            _level = new Level(lines);
            
            _level.Start();
        }
    }
}