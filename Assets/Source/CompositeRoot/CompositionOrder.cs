using System.Collections.Generic;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class CompositionOrder : MonoBehaviour
    {
        [SerializeField] private List<CellCompositeRoot> _cellCompositeRoots;
        [SerializeField] private List<LineCompositeRoot> _lineCompositeRoots;
        [SerializeField] private LevelCompositeRoot _levelCompositeRoot;

        private void Awake()
        {
            foreach (var cellCompositeRoot in _cellCompositeRoots)
            {
                print("AAAA");
                cellCompositeRoot.Compose();
            }

            foreach (var lineCompositeRoot in _lineCompositeRoots)
                lineCompositeRoot.Compose();
            
            _levelCompositeRoot.Compose();
        }
    }
}