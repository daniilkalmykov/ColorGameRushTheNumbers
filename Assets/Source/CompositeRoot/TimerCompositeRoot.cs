using Source.TimersSystem;
using TMPro;
using UnityEngine;

namespace Source.CompositeRoot
{
    [RequireComponent(typeof(TMP_Text))]
    internal sealed class TimerCompositeRoot : CompositeRoot
    {
        [SerializeField] private float _time;

        private TMP_Text _timeView;
        
        public Timer Timer { get; private set; }

        private void Update()
        {
            Timer!.Update(Time.deltaTime);

            _timeView.text = Timer!.Seconds.ToString().Length == 1
                ? $"{Timer.Minutes} : 0{Timer.Seconds}"
                : $"{Timer.Minutes} : {Timer.Seconds}";
        }

        public override void Compose()
        {
            _timeView = GetComponent<TMP_Text>();
            
            Timer = new Timer(_time);
        }
    }
}