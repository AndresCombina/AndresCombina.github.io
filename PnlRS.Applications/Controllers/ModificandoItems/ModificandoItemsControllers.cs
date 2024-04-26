using Microsoft.EntityFrameworkCore.Query.Internal;
using PnlRS.Data.Data;
using PnlRS.Domain.Entities.CrearItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnlRS.Applications.Controllers.ModificandoItems
{
    public class ModificandoItemsControllers
    {
        public NuevosItems EditarGeneros(int id)
        {
            var db = new MoviesDbContext();

            var consulta = from g in db.Genres
                           where g.Id == id
                           select new NuevosItems
                           {
                               id = g.Id,
                               nombre = g.Name
                           };
            var resultado = consulta.FirstOrDefault();
            return resultado;
        }
        public NuevosItems EditarEstudios(int id)
        {
            var db = new MoviesDbContext();

            var consulta = from e in db.Studios
                           where e.Id == id
                           select new NuevosItems
                           {
                               id = e.Id,
                               nombre = e.Name
                           };
            var resultado = consulta.FirstOrDefault();
            return resultado;
                          
        }
        public NuevosItems EditarLanguajes(int id)
        {
            var db = new MoviesDbContext();

            var consulta = from l in db.Languages
                           where l.Id == id
                           select new NuevosItems
                           {
                               id = l.Id,
                               nombre = l.Name
                           };
            var resultado = consulta.FirstOrDefault();
            return resultado;
        }
        public NuevosItems EditarPais(int id)
        {
            var db = new MoviesDbContext();

            var consulta = from p in db.Countries
                           where p.Id == id
                           select new NuevosItems
                           {
                               id = p.Id,
                               nombre = p.Name
                           };
            var resultado = consulta.FirstOrDefault();
            return resultado;
        }
        public NuevosItems EditarCertificados(int id)
        {
            var db = new MoviesDbContext();

            var consulta = from c in db.Certificates
                           where c.Id == id
                           select new NuevosItems
                           {
                               id = c.Id,
                               nombre = c.Name
                           };
            var resultado = consulta.FirstOrDefault();
            return resultado;
        }
        public NuevosItems EditarActores(int id)
        {
            var db = new MoviesDbContext();

            var consulta = from a in db.Actors
                           where a.Id == id
                           select new NuevosItems
                           {
                               id = a.Id,
                               nombre = a.Name
                           };
            var resultado = consulta.FirstOrDefault();
            return resultado;
        }
        public NuevosItems EditarAudiciones(int id)
        {
            var db = new MoviesDbContext();

            var consulta = from c in db.Castings
                           where c.Id == id
                           select new NuevosItems
                           {
                               id = c.Id,
                               nombre = c.CharacterName
                           };
            var resultado = consulta.FirstOrDefault();
            return resultado;
        }
        public NuevosItems EditarDirectores(int id)
        {
            var db = new MoviesDbContext();

            var consulta = from d in db.Directors
                           where d.Id == id
                           select new NuevosItems
                           {
                               id = d.Id,
                               nombre = d.Name
                           };
            var resultado = consulta.FirstOrDefault();
            return resultado;
        }
    }
}
