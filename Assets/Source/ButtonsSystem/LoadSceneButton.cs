using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Source.ButtonsSystem
{
    internal sealed class LoadSceneButton : GameButton
    {
        [SerializeField] private SceneAsset _scene;

        public void Init(SceneAsset scene)
        {
            _scene = scene;
        }
        
        protected override void OnClick()
        {
            SceneManager.LoadScene(_scene.name);
        }
    }
}