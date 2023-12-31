using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using UnityEngine;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
[assembly: InternalsVisibleTo("Lil_biba.ColorGameRushTheNumbers.ButtonsSystem")]
namespace Source.PlayerProgressSystem
{
    internal static class PlayerProgressSaver
    {
        private const string Money = "Money";
        private const string LastClaimedTime = "LastClaimedTime";
        private const string Streak = "Streak";
        private const string IsBought = "IsBought";
        private const string GamesCount = "GamesCount";

        public static void SetMoney(int money)
        {
            PlayerPrefs.SetInt(Money, money);
        }

        public static int GetMoney()
        {
            return PlayerPrefs.GetInt(Money);
        }

        public static void SetLastClaimedTime(DateTime dateTime)
        {
            PlayerPrefs.SetString(LastClaimedTime, dateTime.ToString(CultureInfo.CurrentCulture));
        }

        public static DateTime? GetLastClaimedTime()
        {
            var result = PlayerPrefs.GetString(LastClaimedTime);

            if (string.IsNullOrEmpty(result))
                return null;

            return DateTime.Parse(result, CultureInfo.CurrentCulture);
        }
        
        public static void SetStreak(int id)
        {
            PlayerPrefs.SetInt(Streak, id);
        }

        public static int GetStreak()
        {
            return PlayerPrefs.GetInt(Streak);
        }

        public static void SetBoughtStatus(bool isBought)
        {
            PlayerPrefs.SetInt(IsBought, isBought ? 1 : 0);
        }
        
        public static bool GetBoughtStatus()
        {
            var index = PlayerPrefs.GetInt(IsBought);

            return index != 0;
        }

        public static void SetGamesCount(int gamesCount)
        {
            PlayerPrefs.SetInt(GamesCount, gamesCount);
        }
        
        public static int GetGamesCount()
        {
            return PlayerPrefs.GetInt(GamesCount);
        }
    }
}