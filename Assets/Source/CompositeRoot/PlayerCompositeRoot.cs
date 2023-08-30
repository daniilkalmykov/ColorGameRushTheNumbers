using System.Collections.Generic;
using Source.PlayerProgressSystem;
using Source.Wallet;
using TMPro;
using UnityEngine;

namespace Source.CompositeRoot
{
    internal sealed class PlayerCompositeRoot : CompositeRoot
    {
        [SerializeField] private List<TMP_Text> _moneys; 
        
        public IWallet Wallet { get; private set; }

        private void OnDisable()
        {
            Wallet!.MoneyChanged -= OnMoneyChanged;
        }

        public override void Compose()
        {
            Wallet = new Wallet.Wallet((uint)PlayerProgressSaver.GetMoney());

            Wallet.MoneyChanged += OnMoneyChanged;

            if (_moneys == null) 
                return;

            foreach (var money in _moneys)
                money.text = Wallet.CurrentMoney.ToString();
        }

        private void OnMoneyChanged()
        {
            if (_moneys == null || Wallet == null)
                return;

            foreach (var money in _moneys)
                money.text = Wallet.CurrentMoney.ToString();
        }
    }
}