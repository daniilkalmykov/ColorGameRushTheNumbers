using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Source.RewardSystem
{
    internal sealed class Reward : IReward
    {
        public int Money { get; }

        public Reward(int money)
        {
            Money = money;
        }
    }
}