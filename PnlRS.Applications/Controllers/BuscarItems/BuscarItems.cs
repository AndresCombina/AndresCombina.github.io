using PnlRS.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnlRS.Applications.Controllers.BuscarItems
{
    public class BuscarItems
    {
        public List<Genre> BuscarGeneros()
        {
            var db = new MoviesDbContext();

            var consulta = from g in db.Genres
                           orderby g.Id descending
                           select g;

            var resultado = consulta.ToList();

            return resultado;
        }

        public List<Studio> BuscarEstudios()
        {
            var db = new MoviesDbContext();

            var consulta = from e in db.Studios
                           orderby e.Id descending
                           select e;

            var resultado = consulta.ToList();

            return resultado;
        }

        public List<Language> BuscarLanguajes()
        {
            var db = new MoviesDbContext();

            var consulta = from l in db.Languages
                           orderby l.Id descending
                           select l;

            var resultado = consulta.ToList();

            return resultado;
        }

        public List<Country> BuscarPais()
        {
            var db = new MoviesDbContext();

            var consulta = from p in db.Countries
                           orderby p.Id descending
                           select p;

            var resultado = consulta.ToList();

            return resultado;
        }
        public List<Certificate> BuscarCertificados()
        {
            var db = new MoviesDbContext();

            var consulta= from c in db.Certificates
                          orderby c.Id descending
                          select c;
            var resultado = consulta.ToList();
            return resultado;
        }
        public List<Actor> BuscarActores()
        {
            var db = new MoviesDbContext();
            
            var consulta= from a in db.Actors
                          orderby a.Id descending
                          select a;
            var resultado = consulta.ToList();  
            return resultado;
        }
        public List<Casting> BuscarAudiciones()
        {
            var db = new MoviesDbContext();

            var consulta = from c in db.Castings
                           orderby c.Id descending
                           select c;
            var resultado = consulta.ToList();
            return resultado;
        }
        public List<Director> BuscarDirectores()
        {
            var db = new MoviesDbContext();

            var consulta = from d in db.Directors
                           orderby d.Id descending
                           select d;
            var resultado = consulta.ToList();
            return resultado;
        }

    }
}
