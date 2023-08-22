using System;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Assembly-CSharp")]
namespace Source.Wallet
{
    internal sealed class Wallet : IWallet
    {
        public Wallet(uint currentMoney)
        {
            CurrentMoney = currentMoney;
        }

        public uint CurrentMoney { get; private set; }
        
        public void AddMoney(int money)
        {
            if (money <= 0)
                throw new ArgumentException();

            CurrentMoney += (uint)money;
        }

        public void Spend(int money)
        {
            if (money <= 0)
                throw new ArgumentException();

            CurrentMoney -= (uint)money;
        }
    }
}