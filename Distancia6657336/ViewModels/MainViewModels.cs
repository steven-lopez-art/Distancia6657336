using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Distancia6657336.ViewModels
{
    public partial class MainViewModels : ObservableObject
    {
        [ObservableProperty]
        public double numero1;

        [ObservableProperty]
        public double numero2;

        [ObservableProperty]
        public double numero3;

        [ObservableProperty]
        public double numero4;

        [ObservableProperty]
        public double respuesta;


        [RelayCommand]
        public void Distancia()
        {
            Respuesta = Math.Sqrt(Math.Pow((Numero1 - Numero2), 2) + Math.Pow((Numero3 - Numero4), 2));
        }
    }
}