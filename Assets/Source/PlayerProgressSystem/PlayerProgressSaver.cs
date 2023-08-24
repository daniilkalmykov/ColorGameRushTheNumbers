using UnityEngine;

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