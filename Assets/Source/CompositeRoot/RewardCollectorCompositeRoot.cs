using System;
using System.Collections.Generic;
using Source.ButtonsSystem;
using Source.PlayerProgressSystem;
using Source.Wallet;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class RewardCollectorCompositeRoot : CompositeRoot
    {
        [SerializeField] private List<RewardCompositeRoot> _rewardCompositeRoots;
        [SerializeField] private float _claimCoolDown;
        [SerializeField] private float _claimDeadLine;
        [SerializeField] private int _maxStreak;
        [SerializeField] private MonoBehaviour _bonusView;
        [SerializeField] private CollectRewardButton _collectRewardButton;

        private IWallet _wallet;
        
        public void Init(IWallet wallet)
        {
            _wallet = wallet ?? throw new ArgumentNullException();
        }
        
        public override void Compose()
        {
            var streak = PlayerProgressSaver.GetStreak();

            for (var i = 0; i < _rewardCompositeRoots.Count; i++)
            {
                if (i < streak)
                    _rewardCompositeRoots[i].SetDeactivatedImage();
                else if(i == streak)
                    _collectRewardButton.Init(_rewardCompositeRoots[i].Reward, _wallet);
                else
                    _rewardCompositeRoots[i].SetNonCollectedImage();
            }

            var lastClaimedTime = PlayerProgressSaver.GetLastClaimedTime();
            var claimedTime = DateTime.Now - lastClaimedTime;

            if (claimedTime?.TotalHours <= _claimDeadLine && claimedTime.Value.TotalHours >= _claimCoolDown ||
                lastClaimedTime == null)
            {
                _bonusView.gameObject.SetActive(true);
                
                streak++;

                if (streak > _maxStreak)
                    streak = 0;

                PlayerProgressSaver.SetStreak(streak);
            }
            else if (claimedTime.Value.TotalHours > _claimDeadLine)
            {
                PlayerProgressSaver.SetStreak(0);
            }
        }
    }
}