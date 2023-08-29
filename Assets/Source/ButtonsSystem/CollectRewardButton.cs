using System;
using Source.PlayerProgressSystem;
using Source.RewardSystem;
using UnityEngine;

namespace Source.ButtonsSystem
{
    internal sealed class CollectRewardButton : GameButton
    {
        [SerializeField] private MonoBehaviour _background;
        
        private IReward _reward;
        
        public void Init(IReward reward)
        {
            _reward = reward;
        }
        
        protected override void OnClick()
        {
            PlayerProgressSaver.SetMoney(PlayerProgressSaver.GetMoney() + _reward.Money);
            PlayerProgressSaver.SetLastClaimedTime(DateTime.Now);

            _background.gameObject.SetActive(false);
        }
    }
}