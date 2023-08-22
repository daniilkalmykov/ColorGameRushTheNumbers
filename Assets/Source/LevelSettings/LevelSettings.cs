using System.Collections.Generic;
using UnityEngine;

namespace Source.LevelSettings
{
    [CreateAssetMenu(fileName = "Settings", menuName = "Level settings", order = 51)]
    internal sealed class LevelSettings : ScriptableObject
    {
        [SerializeField] private List<int> _lineSums;

        public IEnumerable<int> Sums => _lineSums;
    }
}