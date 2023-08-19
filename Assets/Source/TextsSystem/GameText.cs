using TMPro;
using UnityEngine;

namespace Source.TextsSystem
{
    [RequireComponent(typeof(TMP_Text))]
    internal sealed class GameText : MonoBehaviour
    {
        private TMP_Text _text;

        public void Init()
        {
            _text = GetComponent<TMP_Text>();
        }

        public void Show(string text)
        {
            _text.text = text;
        }
    }
}