using System.Collections.Generic;
using Source.LevelSettings;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class CompositionOrder : MonoBehaviour
    {
        [SerializeField] private List<CellCompositeRoot> _cellCompositeRoots;
        [SerializeField] private List<LineCompositeRoot> _lineCompositeRoots;
        [SerializeField] private LevelCompositeRoot _levelCompositeRoot;
        [SerializeField] private PlayerCompositeRoot _playerCompositeRoot;

        private void Awake()
        {
            _playerCompositeRoot.Compose();
            
            foreach (var cellCompositeRoot in _cellCompositeRoots)
                cellCompositeRoot.Compose();

            var levelSettings = LevelSettingsSaver.GetLevelSettings();
            
            for (var i = 0; i < _lineCompositeRoots.Count; i++)
            {
                _lineCompositeRoots[i].Init(levelSettings.TryGetSum((uint)i));
                _lineCompositeRoots[i].Compose();
            }

            _levelCompositeRoot.Init(levelSettings.Prize, _playerCompositeRoot.Wallet);
            _levelCompositeRoot.Compose();
        }
    }
}