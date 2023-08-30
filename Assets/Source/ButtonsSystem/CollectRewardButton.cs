using System;
using Source.PlayerProgressSystem;
using Source.RewardSystem;
using Source.Wallet;
using UnityEngine;

namespace Source.ButtonsSystem
{
    internal sealed class CollectRewardButton : GameButton
    {
        [SerializeField] private MonoBehaviour _background;
        
        private IReward _reward;
        private IWallet _wallet;
        
        public void Init(IReward reward, IWallet wallet)
        {
            _reward = reward ?? throw new ArgumentNullException();
            _wallet = wallet ?? throw new ArgumentNullException();
        }
        
        protected override void OnClick()
        {
            _wallet.AddMoney(_reward.Money);
            
            PlayerProgressSaver.SetMoney((int)_wallet.CurrentMoney);
            PlayerProgressSaver.SetLastClaimedTime(DateTime.Now);

            _background.gameObject.SetActive(false);
        }
    }
}