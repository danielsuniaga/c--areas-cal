using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Codifico_Test_C_
{

    /*class that will process all area calculations*/
    public class area_calculus
    {

        /*class constructor*/
        public area_calculus() { }

        /*method that calculates the area of a circle*/
        public string circle(double radio)
        {

            try
            {

                double areaCirculo = Math.PI * Math.Pow(radio, 2);

                return $"El área del círculo con radio {radio} es: {areaCirculo}";

            }
            catch (Exception ex)
            {

                return $"Error al calcular el área del círculo: {ex.Message}";

            }

        }

        /*method that calculates the area of a rectangle*/

        public string rectangle(double rectangle_base, double rectangle_height)
        {

            try
            {

                double rectangle_area = rectangle_base * rectangle_height;

                return $"El área del rectángulo con base {rectangle_base} y altura {rectangle_height} es: {rectangle_area}";

            }
            catch (Exception ex)
            {
                return $"Error al calcular el área del rectángulo: {ex.Message}";
            }

        }

    }
}
