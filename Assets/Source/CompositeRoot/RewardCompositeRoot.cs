using Source.ButtonsSystem;
using Source.RewardSystem;
using UnityEngine;
using UnityEngine.UI;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(Image))]
    internal sealed class RewardCompositeRoot : CompositeRoot
    {
        [SerializeField] private int _money;
        [SerializeField] private Sprite _deactivatedSprite;
        [SerializeField] private Sprite _nonCollected;

        private Image _image;
        
        public Reward Reward { get; private set; }

        public override void Compose()
        {
            _image = GetComponent<Image>();
            
            Reward = new Reward(_money);
        }

        public void SetDeactivatedImage()
        {
            _image.sprite = _deactivatedSprite;
        }

        public void SetNonCollectedImage()
        {
            _image.sprite = _nonCollected;
        }
    }
}