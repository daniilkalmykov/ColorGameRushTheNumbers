namespace Source.Wallet
{
    public interface IWallet
    {
        uint CurrentMoney { get; }

        void AddMoney(int money);
        void Spend(int money);
    }
}