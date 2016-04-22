using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Validation;


namespace EstadisticaPelotaEnlaceDatos
{
    public class jugadoresDALC
    {
        public List<Jugadores> GetJugadores()
        {
            using (EstadisticaDbEntities db = new EstadisticaDbEntities())
            {
                return db.Jugadores.ToList();
            }

        }

        public void setLiga(string a)
        {
            using (EstadisticaDbEntities context = new EstadisticaDbEntities())
            {
                Ligas liga = new Ligas()
                {
                   tipo = a,
                };
                 try
                                    {
                                        context.Ligas.Add(liga);
                                        context.SaveChanges();
                                        Console.WriteLine("escrito en Base de datos");
                                    }
                                    catch (DbEntityValidationException dbEx)
                                    {
                                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                                        {
                                            foreach (var validationError in validationErrors.ValidationErrors)
                                            {
                                                System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                                            }
                                        }
                                    }
                               
               
            }

        }
        public void SetJugadores(string a, string b, string c, string d, string e, int f, int g, int h)
        {
            using (EstadisticaDbEntities Context = new EstadisticaDbEntities())
                                {


                                    Jugadores jugador = new Jugadores()
                                    {
                                        Nombre = a,
                                        Ponche = b,
                                        Hits = c,
                                        Carreras = d,
                                        HomeRun = e,
                                        EquipoId = f,
                                        PosicionID = g,
                                        ligaID = h

                                    };
                                    try
                                    {
                                        Context.Jugadores.Add(jugador);
                                        Context.SaveChanges();
                                        Console.WriteLine("escrito en Base de datos");
                                    }
                                    catch (DbEntityValidationException dbEx)
                                    {
                                        foreach (var validationErrors in dbEx.EntityValidationErrors)
                                        {
                                            foreach (var validationError in validationErrors.ValidationErrors)
                                            {
                                                System.Console.WriteLine("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                                            }
                                        }
                                    }
                               
                                    
                                   

                                }
                   

        }

    }
}
