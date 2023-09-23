using Infrastructure.Services.Timer;
using UnityEngine;
using Zenject;

namespace Gameplay
{
    public class TimerTester : MonoBehaviour
    {
        [SerializeField] private float _timerCapacity = 15f;
        private XTimer _timer;
        
        [Inject]
        public void Construct(XTimer.Factory timer)
        {
            _timer = timer.Create(TimerType.OneSecondTick, _timerCapacity);
            
            _timer.OnTimerValueChanged += LogTimer;
            _timer.OnTimerFinished += TimerFinishedLog;
        }

        private void Update()
        {
            if(_timer == null) 
                return;
            
            if(Input.GetKeyDown(KeyCode.S)) 
                _timer.Start();

            if (Input.GetKeyDown(KeyCode.LeftArrow)) 
                _timer.Pause();

            if (Input.GetKeyDown(KeyCode.RightArrow)) 
                _timer.Unpause();

            if (Input.GetKeyDown(KeyCode.D)) 
                _timer.SetTime(_timerCapacity);
        }

        private void OnDestroy()
        {
            _timer.OnTimerValueChanged -= LogTimer;
            _timer.OnTimerFinished -= TimerFinishedLog;
        }

        private void LogTimer(float remainingSeconds, TimerChangingSourceType changingSource) => 
            Debug.Log($"RemainingTime: {_timer.RemainingSeconds} TimeChangingSource: {changingSource}");

        private void TimerFinishedLog() => 
            Debug.Log($"Timer Finished");
    }
}