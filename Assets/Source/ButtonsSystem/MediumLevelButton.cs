using Source.PlayerProgressSystem;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Source.ButtonsSystem
{
    internal sealed class MediumLevelButton : GameButton
    {
        [SerializeField] private MonoBehaviour _buyImage;
        [SerializeField] private SceneAsset _sceneAsset;
        [SerializeField] private BuyButton _button;
        [SerializeField] private Image _lock;

        private bool _isBought;

        private void Start()
        {
            _isBought = PlayerProgressSaver.GetBoughtStatus();

            if (_isBought)
                _lock.gameObject.SetActive(false);
        }

        protected override void OnClick()
        {
            _isBought = PlayerProgressSaver.GetBoughtStatus();
            
            if (_isBought == false)
            {
                _buyImage.gameObject.SetActive(true);
                _button.gameObject.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene(_sceneAsset.name);
            }
        }
    }
}