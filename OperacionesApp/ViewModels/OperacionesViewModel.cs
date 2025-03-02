using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace OperacionesApp.ViewModels
{
    public partial class OperacionesViewModel:ObservableObject
    {


        [ObservableProperty]
        private double ladoCuadrado;

        [ObservableProperty]
        private double radioCirculo;

        [ObservableProperty]
        private double baseRectangulo;

        [ObservableProperty]
        private double alturaRectangulo;
        
        
        [ObservableProperty]
        private double cuadradoArea;
        
        [ObservableProperty]
        private double circuloArea;
        
        [ObservableProperty]
        private double rectanguloArea;

        private string CalculocuadradoArea;
        private string CalculocirculoArea;
        private string CalculorectanguloArea;

        [RelayCommand]
        private void AreaCuadrado()

        {

            try
            {
                cuadradoArea= ladoCuadrado * ladoCuadrado;
                CalculocuadradoArea=cuadradoArea.ToString();
                Alerta("ERROR", CalculocuadradoArea);
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
                throw;
            }
            
            
        }
        
        [RelayCommand]
        private void AreaCirculo()
        {

            try
            {
                circuloArea = 3.14 * radioCirculo * radioCirculo;
                CalculocirculoArea = circuloArea.ToString();
                Alerta("ERROR", CalculocirculoArea);
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message); 
                throw;
            }


            
        }
        
        [RelayCommand]
        private void AreaRectangulo()
        {

            try
            {
                rectanguloArea = baseRectangulo * alturaRectangulo;
                CalculorectanguloArea = rectanguloArea.ToString();
                Alerta("ERROR", CalculorectanguloArea);
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
                throw;
            }



            
        }


        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Limpiar()
        {
            ladoCuadrado = 0;
            radioCirculo = 0;
            baseRectangulo = 0;
            alturaRectangulo = 0;
            cuadradoArea = 0;
            circuloArea = 0;
            rectanguloArea = 0;
        }

    }
}
