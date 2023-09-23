using System;

namespace Infrastructure.Services.Timer
{
    public interface ITimeTickProvider
    {
        event Action<float> OnUpdateTimerTicked;
        event Action<float> OnUnscaledUpdateTimerTicked;
        event Action OnOneSecondUpdateTimerTicked;
        event Action OnOneSecondUnscaledUpdateTimerTicked;
    }
}