using Infrastructure.Services.Timer.Installer;
using Zenject;

namespace Installers
{
    public class GameInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindTimerService();
        }

        private void BindTimerService()
        {
            TimerInstaller.Install(Container);
        }
    }
}