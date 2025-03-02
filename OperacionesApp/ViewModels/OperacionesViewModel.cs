using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace OperacionesApp.ViewModels
{
    internal partial class OperacionesViewModel:ObservableObject
    {
        [ObservableProperty]
        public double ladoCuadrado;

        [ObservableProperty]
        public double radioCirculo;

        [ObservableProperty]
        public double baseRectangulo;

        [ObservableProperty]
        public double alturaRectangulo;

        [RelayCommand]
        private double AreaCuadrado()
        {
            return ladoCuadrado * ladoCuadrado;
        }

        [RelayCommand]
        private double AreaCirculo()
        {
            return 3.14*radioCirculo*radioCirculo;
        }

        [RelayCommand]
        private double AreaRectangulo()
        {

            return baseRectangulo*alturaRectangulo;
        }


        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }



    }
}
