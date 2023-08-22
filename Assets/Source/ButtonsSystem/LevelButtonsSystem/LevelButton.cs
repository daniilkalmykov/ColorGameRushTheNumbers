using Source.LevelSettings;
using UnityEngine;

namespace Source.ButtonsSystem.LevelButtonsSystem
{
    internal sealed class LevelButton : GameButton
    {
        [SerializeField] private LevelSettings.LevelSettings _levelSettings;
        
        protected override void OnClick()
        {
            LevelSettingsSaver.Save(_levelSettings);
        }
    }
}