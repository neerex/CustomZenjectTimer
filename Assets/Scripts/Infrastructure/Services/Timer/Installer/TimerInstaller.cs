using Zenject;

namespace Infrastructure.Services.Timer.Installer
{
    public class TimerInstaller : Installer<TimerInstaller>
    {
        public override void InstallBindings()
        {
            Container.BindInterfacesTo<TimeTickProvider>().AsSingle();
            Container.BindFactory<TimerType, float, XTimer, XTimer.Factory>().AsSingle();
        }
    }
}