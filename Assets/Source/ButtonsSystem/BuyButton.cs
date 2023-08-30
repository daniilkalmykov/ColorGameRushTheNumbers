using System;
using Source.PlayerProgressSystem;
using Source.Wallet;
using UnityEngine;
using UnityEngine.UI;

namespace Source.ButtonsSystem
{
    internal sealed class BuyButton : GameButton
    {
        [SerializeField] private int _price;
        [SerializeField] private Image _text;
        [SerializeField] private Image _background;
        [SerializeField] private Image _lock;
        
        private IWallet _wallet;

        protected override void OnEnable()
        {
            base.OnEnable();

            if (_price <= PlayerProgressSaver.GetMoney())
            {
                _text.gameObject.SetActive(false);
                return;
            }

            _text.gameObject.SetActive(true);
            gameObject.SetActive(false);
        }

        public void Init(IWallet wallet)
        {
            _wallet = wallet ?? throw new ArgumentNullException();
        }
        
        protected override void OnClick()
        {
            _lock.gameObject.SetActive(false);
            
            _wallet.Spend(_price);
            
            PlayerProgressSaver.SetMoney((int)_wallet.CurrentMoney);
            PlayerProgressSaver.SetBoughtStatus(true);

            _background.gameObject.SetActive(false);
        }
    }
}