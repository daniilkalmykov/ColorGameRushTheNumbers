using System;
using System.Collections.Generic;
using Source.PlayerProgressSystem;
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
        
        public override void Compose()
        {
            var streak = PlayerProgressSaver.GetStreak();

            for (var i = 0; i < _rewardCompositeRoots.Count; i++)
            {
                if (i != streak)
                    _rewardCompositeRoots[i].Deactivate();
            }

            var lastClaimedTime = PlayerProgressSaver.GetLastClaimedTime();

            var claimedTime = DateTime.Now - lastClaimedTime;

            if (claimedTime.TotalHours <= _claimDeadLine && claimedTime.TotalHours >= _claimCoolDown)
            {
                _bonusView.gameObject.SetActive(true);
                
                streak++;

                if (streak > _maxStreak)
                    streak = 0;

                PlayerProgressSaver.SetStreak(streak);
            }
            else if (claimedTime.Hours > _claimDeadLine)
            {
                PlayerProgressSaver.SetStreak(0);
            }
        }
    }
}