using System.Collections.Generic;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class MainMenuCompositeOrder : CompositeRoot
    {
        [SerializeField] private List<RewardCompositeRoot> _rewardCompositeRoots;
        
        public override void Compose()
        {
            foreach (var rewardCompositeRoot in _rewardCompositeRoots)
                rewardCompositeRoot.Compose();
        }
    }
}