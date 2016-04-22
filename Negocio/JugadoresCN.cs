using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstadisticaPelotaEnlaceDatos;
using System.Windows.Forms;
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

       public static void LimpiarTextBox(Form a)
       {
           a.Controls.OfType<TextBox>().ToList().ForEach(o => o.Text = "");

       }


    }
}
