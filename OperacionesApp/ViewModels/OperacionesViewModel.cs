using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace OperacionesApp.ViewModels
{
    class OperacionesViewModel:ObservableObject
    {
        [ObservableProperty]
        public double ladoCuadrado { get; set; }

        [ObservableProperty]
        public double radioCirculo { get; set; }

        [ObservableProperty]
        public double baseRectangulo { get; set; }

        [ObservableProperty]
        public double alturaRectangulo { get; set; }

        [RelayCommand]
        public double areaCuadrado(double ladoCuadrado)
        {
            ladoCuadrado=this.ladoCuadrado;

            return ladoCuadrado * ladoCuadrado;
        }

        [RelayCommand]
        public double areaCirculo(double radioCirculo)
        {
            radioCirculo = this.radioCirculo;

            return 3.14*radioCirculo*radioCirculo;
        }

        [RelayCommand]
        public double areaRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            baseRectangulo = this.baseRectangulo;
            alturaRectangulo = this.alturaRectangulo;

            return baseRectangulo*alturaRectangulo;
        }

    }
}
