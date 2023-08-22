using UnityEngine;
using UnityEngine.SceneManagement;

namespace Source.ButtonsSystem
{
    internal sealed class LoadSceneButton : GameButton
    {
        [SerializeField] private SceneName _sceneName;
        
        protected override void OnClick()
        {
            SceneManager.LoadScene(_sceneName.ToString());
        }
    }

    enum SceneName
    {
        ThreeXThree,
        MainMenu,
        FourXFour,
    }
}