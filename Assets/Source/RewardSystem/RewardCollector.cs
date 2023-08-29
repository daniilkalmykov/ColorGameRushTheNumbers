using System.Collections.Generic;
using Source.PlayerProgressSystem;

namespace Source.RewardSystem
{
    internal sealed class RewardCollector
    {
        private readonly List<Reward> _rewards;

        public RewardCollector(List<Reward> rewards)
        {
            _rewards = rewards;
        }

        public void Collect(int id)
        {
            PlayerProgressSaver.SetMoney(_rewards[id].Money);
        }
    }
}