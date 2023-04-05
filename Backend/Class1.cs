using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Fecha
    {
        public int fecha { get; set; }
        public int dia { get; set; }
        public int mes { get; set; }


        public int fechacom()
        {
            int total = 0;
            if (dia < 31)
            {
                
                total = (dia + 1);
                return total;
            }
            else
            {
                dia = 1;
                total = dia;
                return total;
            }
        }
        public string Mes()
        {
            string total2 = "";
            if (mes==1)
            {
                total2 = "Enero";

            }
            if (mes == 2)
            {
                total2 = "Febrero";

            }
            if (mes == 3)
            {
                total2 = "Marzo";

            }
            if (mes == 4)
            {
                total2 = "Abril";

            }
            if (mes == 5)
            {
                total2 = "Mayo";

            }
            if (mes == 6)
            {
                total2 = "Junio";

            }
            if (mes == 7)
            {
                total2 = "Julio";

            }
            if (mes == 8)
            {
                total2 = "Agosto";

            }
            if (mes == 9)
            {
                total2 = "Septiembre";

            }
            if (mes == 10)
            {
                total2 = "Octubre";

            }
            if (mes == 11)
            {
                total2 = "Noviembre";

            }
            if (mes == 12)
            {
                total2 = "Diciembre";

            }
            return total2;

        }




    }
}
