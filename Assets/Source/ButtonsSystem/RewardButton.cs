using Source.PlayerProgressSystem;
using Source.RewardSystem;

namespace Source.ButtonsSystem
{
    internal sealed class RewardButton : GameButton
    {
        private IReward _reward;
        
        public void Init(IReward reward)
        {
            _reward = reward;
        }
        
        protected override void OnClick()
        {
            PlayerProgressSaver.SetMoney(_reward.Money);
        }
    }
}