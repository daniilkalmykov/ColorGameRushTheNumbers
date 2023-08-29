using UnityEngine;
using UnityEngine.UI;

namespace Source.ButtonsSystem
{
    [RequireComponent(typeof(Button))]
    public abstract class GameButton : MonoBehaviour
    {
        public Button Button { get; private set; }

        private void Awake()
        {
            Button = GetComponent<Button>();
        }

        private void OnEnable()
        {
            Button.onClick.AddListener(OnClick);
        }

        private void OnDisable()
        {
            Button.onClick.RemoveListener(OnClick);
        }

        protected abstract void OnClick();
    }
}