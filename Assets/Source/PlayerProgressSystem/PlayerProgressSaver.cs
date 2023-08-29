using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
[assembly: InternalsVisibleTo("Lil_biba.ColorGameRushTheNumbers.RewardSystem")]
namespace Source.PlayerProgressSystem
{
    internal static class PlayerProgressSaver
    {
        private const string Money = "Money";

        public static void SetMoney(int money)
        {
            PlayerPrefs.SetInt(Money, money);
        }

        public static int GetMoney()
        {
            return PlayerPrefs.GetInt(Money);
        }
    }
}