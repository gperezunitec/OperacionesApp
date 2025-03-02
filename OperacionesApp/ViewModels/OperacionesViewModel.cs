using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesApp.ViewModels
{
    class OperacionesViewModel
    {

        public double ladoCuadrado { get; set; }
        public double radioCirculo { get; set; }
        public double baseRectangulo { get; set; }
        public double alturaRectangulo { get; set; }

        public double areaCuadrado(double ladoCuadrado)
        {
            ladoCuadrado=this.ladoCuadrado;

            return ladoCuadrado * ladoCuadrado;
        }

        public double areaCirculo(double radioCirculo)
        {
            radioCirculo = this.radioCirculo;

            return 3.14*radioCirculo*radioCirculo;
        }

        public double areaRectangulo(double baseRectangulo, double alturaRectangulo)
        {
            baseRectangulo = this.baseRectangulo;
            alturaRectangulo = this.alturaRectangulo;

            return baseRectangulo*alturaRectangulo;
        }

    }
}
