using System.Collections.Generic;
using Source.ButtonsSystem;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class MainMenuCompositeOrder : MonoBehaviour
    {
        [SerializeField] private List<RewardCompositeRoot> _rewardCompositeRoots;
        [SerializeField] private RewardCollectorCompositeRoot _collectorCompositeRoot;
        [SerializeField] private BuyButton _buyButton;
        [SerializeField] private PlayerCompositeRoot _playerCompositeRoot;
        
        private void Awake()
        {
            foreach (var rewardCompositeRoot in _rewardCompositeRoots)
                rewardCompositeRoot.Compose();
            
            _playerCompositeRoot.Compose();
            
            _collectorCompositeRoot.Init(_playerCompositeRoot.Wallet);
            _buyButton.Init(_playerCompositeRoot.Wallet);

            _collectorCompositeRoot.Compose();
        }
    }
}