using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalificacionLeida
{
    public class CalificacionDeClase
    {
        public decimal calicaptura, promediogrupal = 0, sumacalif = 0;
        public int reprobados = 0, aprobados = 0;
       
      

    public void contarAprobacion()
        {
            if (calicaptura < 70)
            {        
            reprobados++;
            }
                
            else
            {
             aprobados++;
            }
                
        }

        public void sumarcalificaciones()
        {
            sumacalif += calicaptura;
        }

           public decimal calcularPromedio()
        {
            promediogrupal = sumacalif / (aprobados + reprobados);
                
            return promediogrupal;
        }



    }

}
