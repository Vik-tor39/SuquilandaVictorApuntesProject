using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SuquilandaVictorApuntesProject.ViewModels
{
    internal class VSuquilandaAboutViewModel
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://aka.ms/maui";
        public string Message => "Hola Mundo. Soy Víctor Suquilanda, estudiante de programación IV, y este es el proyecto MAUI MVVM";
        public ICommand ShowMoreInfoCommand { get; }

        public VSuquilandaAboutViewModel()
        {
            ShowMoreInfoCommand = new AsyncRelayCommand(ShowMoreInfo);
        }

        async Task ShowMoreInfo() =>
            await Launcher.Default.OpenAsync(MoreInfoUrl);
    }
}
