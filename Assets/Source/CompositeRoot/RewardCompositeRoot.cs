using Source.ButtonsSystem;
using Source.RewardSystem;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(RewardButton))]
    internal sealed class RewardCompositeRoot : CompositeRoot
    {
        [SerializeField] private int _money;

        private RewardButton _rewardButton;
        private Reward _reward;

        public override void Compose()
        {
            _reward = new Reward(_money);
            
            _rewardButton = GetComponent<RewardButton>();
            _rewardButton.Init(_reward);
        }
    }
}