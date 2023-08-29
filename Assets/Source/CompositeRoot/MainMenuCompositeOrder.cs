using System.Collections.Generic;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class MainMenuCompositeOrder : MonoBehaviour
    {
        [SerializeField] private List<RewardCompositeRoot> _rewardCompositeRoots;
        [SerializeField] private RewardCollectorCompositeRoot _collectorCompositeRoot;
        
        private void Awake()
        {
            foreach (var rewardCompositeRoot in _rewardCompositeRoots)
                rewardCompositeRoot.Compose();
            
            _collectorCompositeRoot.Compose();
        }
    }
}