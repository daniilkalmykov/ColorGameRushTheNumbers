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

        protected virtual void OnEnable()
        {
            _button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnClick);
        }

        protected abstract void OnClick();
    }
}