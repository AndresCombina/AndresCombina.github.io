using PnlRS.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnlRS.Applications.Controllers.ItemsCounts
{
    public class ItemsCounts
    {
        public List<Film> DatosPeliculas()
        {
            var db = new MoviesDbContext();

            var consulta = from p in db.Films
                           select p;

            var resultado= consulta.ToList();

            return resultado; 
        }
        public List<Genre> DatosGeneros()
        {
            var db = new MoviesDbContext();

            var consulta = from g in db.Genres
                           select g;

            var resultado = consulta.ToList();

            return resultado;
        }
        public List<Studio> DatosStudios()
        {
            var db = new MoviesDbContext();

            var consulta = from e in db.Studios
                           select e;
            var resultado = consulta.ToList();
            return resultado;
        }
        public List<Language> DatosLanguages()
        {
            var db = new MoviesDbContext();

            var consulta= from l in db.Languages
                          select l;
            var resultado = consulta.ToList();
            return resultado;
        }
        public List<Country> DatosPaises()
        {
            var db = new MoviesDbContext();

            var consulta = from p in db.Countries
                           select p;
            var resultado = consulta.ToList();
            return resultado;
        }

        public List<Certificate> DatosCertificados()
        {
            var db = new MoviesDbContext();

            var consulta = from c in db.Certificates
                           select c;
            var resultado = consulta.ToList();
            return resultado;
        }

        public List<Actor> DatosActors()
        {
            var db = new MoviesDbContext();

            var consulta = from a in db.Actors
                           select a;
            var resultado = consulta.ToList();
            return resultado;
        }

        public List<Director> DatosDirectores()
        {
            var db = new MoviesDbContext();

            var consulta = from d in db.Directors
                           select d;
            var resultado = consulta.ToList();
            return resultado;
        }
    }
}
