using TMPro;
using UnityEngine;

namespace Source.TextsSystem
{
    [RequireComponent(typeof(TMP_Text))]
    internal abstract class GameText : MonoBehaviour
    {
        protected TMP_Text Text { get; private set; }

        private void Awake()
        {
            Text = GetComponent<TMP_Text>();
        }
    }
}