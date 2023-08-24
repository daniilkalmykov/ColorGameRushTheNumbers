using UnityEngine;
using UnityEngine.UI;

namespace Source.ButtonsSystem
{
    [RequireComponent(typeof(Button))]
    public abstract class GameButton : MonoBehaviour
    {
        private Button _button;

        private void Awake()
        {
            _button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        public void SetImage(Image image)
        {
            _button.image = image;
        }

        protected abstract void OnClick();
    }
}