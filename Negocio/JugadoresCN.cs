using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstadisticaPelotaEnlaceDatos;
namespace Negocio
{
   public class JugadoresCN
    {
       public static List<Jugadores> GetJugadores()
       {
           jugadoresDALC obj = new jugadoresDALC();
                    
           return obj.GetJugadores();
           
       }
       public static void  SetJugadores()
       {
           jugadoresDALC obj = new jugadoresDALC();

           

       }

    }
}
