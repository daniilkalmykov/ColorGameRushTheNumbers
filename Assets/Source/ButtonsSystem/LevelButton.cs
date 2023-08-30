using Source.LevelSettings;
using UnityEngine;

namespace Source.ButtonsSystem
{
    internal sealed class LevelButton : GameButton
    {
        [SerializeField] private LevelSettings.LevelSettings _levelSettings;

        public void Init(LevelSettings.LevelSettings levelSettings)
        {
            _levelSettings = levelSettings;
        }
        
        protected override void OnClick()
        {
            if (_levelSettings != null)
                LevelSettingsSaver.Save(_levelSettings);
        }
    }
}