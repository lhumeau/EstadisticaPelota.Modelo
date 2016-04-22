using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace EstadisticaPelotaEnlaceDatos
{
    public class jugadoresDALC
    {
        public List<Jugadores> GetJugadores()
        {
            using (DbEstadisticaEntities db = new DbEstadisticaEntities())
            {
                return db.Jugadores.ToList();
            }

        }
        public void SetJugadores(string a, string b, string c, string d, string e, int f, int g, int t)
        {
                                using (DbEstadisticaEntities Context = new DbEstadisticaEntities())
                                {


                                    Jugadores jugador = new Jugadores()
                                    {
                                        Nombre = a,
                                        Hits = b,
                                        Carreras = c,
                                        HomeRun = d,
                                        EquipoId = f,
                                        PosicionID = g,
                                        ligaID = t

                                    };

                                    Context.Jugadores.Add(jugador);
                                    Console.WriteLine("escrito en Base de datos");
                                    
                                   

                                }
                   

        }

    }
}
