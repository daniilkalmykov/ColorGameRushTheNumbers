using UnityEngine;

namespace Source.ButtonsSystem
{
    internal sealed class BackButton : GameButton
    {
        [SerializeField] private MonoBehaviour _settingsPanel;
        
        protected override void OnClick()
        {
            _settingsPanel.gameObject.SetActive(false);
        }
    }
}