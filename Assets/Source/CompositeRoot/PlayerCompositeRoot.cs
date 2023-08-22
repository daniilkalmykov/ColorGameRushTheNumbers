using Source.Wallet;

namespace Source.CompositeRoot
{
    internal sealed class PlayerCompositeRoot : CompositeRoot
    {
        public IWallet Wallet { get; private set; }
        
        public override void Compose()
        {
            Wallet = new Wallet.Wallet(0);
        }
    }
}