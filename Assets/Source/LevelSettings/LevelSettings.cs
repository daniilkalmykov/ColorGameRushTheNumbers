using System;
using System.Collections.Generic;
using UnityEngine;

namespace Source.LevelSettings
{
    [CreateAssetMenu(fileName = "Settings", menuName = "Level settings", order = 51)]
    internal sealed class LevelSettings : ScriptableObject, ILevelSettings
    {
        [SerializeField] private List<uint> _lineSums;

        [field: SerializeField] public uint Prize { get; private set; }

        public uint TryGetSum(uint index)
        {
            if (index >= _lineSums.Count)
                throw new ArgumentException();

            return _lineSums[(int)index];
        }
    }
}