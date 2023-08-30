using System;

namespace Source.Wallet
{
    public interface IWallet
    {
        event Action MoneyChanged;
        
        uint CurrentMoney { get; }

        void AddMoney(int money);
        void Spend(int money);
    }
}