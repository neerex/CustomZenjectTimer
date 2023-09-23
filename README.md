# CustomZenjectTimer
This project shows a custom Timer class that uses Zenject Factory and global Tick update. This is pretty flexible timer with extensive functionality that you need for you Time dependent elements (example: cooldown times for abilities)

## Setup
For creating you need to inject XTimer.Factory in to your class that will use timer and do _timer.Create() with TimerType parameter and TimerCapacity.
See the TimerTester example in the project.
