using UnityEngine;

namespace Source.ButtonsSystem
{
    internal sealed class SettingsButton : GameButton
    {
        [SerializeField] private MonoBehaviour _settingsPanel;
        
        protected override void OnClick()
        {
            _settingsPanel.gameObject.SetActive(true);
        }
    }
}