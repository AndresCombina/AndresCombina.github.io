using PnlRS.Data.Data;
using PnlRS.Domain.Entities.CrearItems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnlRS.Applications.Controllers.CrearItems
{
    public class CrearItemControllers
    {
        public void CrearGeneros(NuevosItems items)
        {
            var db = new MoviesDbContext();

            if (items.id == 0)
            {
                var FilaEnDb = new Genre();
                FilaEnDb.Name = items.nombre;
                FilaEnDb.Active = true;
                db.Add(FilaEnDb);
                db.SaveChanges();
            }
            else
            {
                var consulta = (from g in db.Genres
                                where g.Id == items.id
                                select g).FirstOrDefault();
                consulta.Name = items.nombre;
                db.SaveChanges();
            }
             


        }
        public void CrearLenguaje(NuevosItems items)
        {
            var db = new MoviesDbContext();

            if (items.id == 0)
            {
                var FilaEnDb = new Language();
                FilaEnDb.Name = items.nombre;
                FilaEnDb.Active = true;
                db.Add(FilaEnDb);
                db.SaveChanges();
            }
            else
            {
                var consulta = (from l in db.Languages
                                where l.Id == items.id
                                select l).FirstOrDefault();
                consulta.Name = items.nombre;
                db.SaveChanges();
            }

        }
        public void CrearEstudios(NuevosItems items)
        {
            var db = new MoviesDbContext();

            if (items.id == 0)
            {
                var FilaEnDb = new Studio();
                FilaEnDb.Name = items.nombre;
                FilaEnDb.Active = true;
                db.Add(FilaEnDb);
                db.SaveChanges();
            }
            else
            {
                var consulta = (from s in db.Studios
                                where s.Id == items.id
                                select s).FirstOrDefault();
                consulta.Name = items.nombre;
                db.SaveChanges();
            }

        }
        public void CrearPais(NuevosItems items)
        {
            var db = new MoviesDbContext();

            if (items.id == 0)
            {
                var FilaEnDb = new Country();
                FilaEnDb.Name = items.nombre;
                FilaEnDb.Active = true;
                db.Add(FilaEnDb);
                db.SaveChanges();
            }
            else
            {
                var consulta = (from c in db.Countries
                                where c.Id == items.id
                                select c).FirstOrDefault();
                consulta.Name = items.nombre;
                db.SaveChanges();
            }

        }
        public void CrearCertificados(NuevosItems items)
        {
            var db = new MoviesDbContext();

            if (items.id == 0)
            {
                var FilaEnDb = new Certificate();
                FilaEnDb.Name = items.nombre;
                FilaEnDb.Active = true;
                db.Add(FilaEnDb);
                db.SaveChanges();
            }
            else
            {
                var consulta = (from c in db.Certificates
                                where c.Id == items.id
                                select c).FirstOrDefault();
                consulta.Name = items.nombre;
                db.SaveChanges();
            }

        }
        public void CrearActores(NuevosItems items)
        {
            var db = new MoviesDbContext();

            if (items.id == 0)
            {
                var FilaEnDb = new Actor();
                FilaEnDb.Name = items.nombre;
                FilaEnDb.Active = true;
                db.Add(FilaEnDb);
                db.SaveChanges();
            }
            else
            {
                var consulta = (from a in db.Actors
                                where a.Id == items.id
                                select a).FirstOrDefault();
                consulta.Name = items.nombre;
                db.SaveChanges();
            }

        }
        public void CrearAudiciones(NuevosItems items)
        {
            var db = new MoviesDbContext();

            if (items.id == 0)
            {
                var FilaEnDb = new Casting();
                FilaEnDb.CharacterName = items.nombre;
                FilaEnDb.Active = true;
                db.Add(FilaEnDb);
                db.SaveChanges();
            }
            else
            {
                var consulta = (from a in db.Castings
                                where a.Id == items.id
                                select a).FirstOrDefault();
                consulta.CharacterName = items.nombre;
                db.SaveChanges();
            }

        }
        public void CrearDirectores(NuevosItems items)
        {
            var db = new MoviesDbContext();

            if (items.id == 0)
            {
                var FilaEnDb = new Director();
                FilaEnDb.Name = items.nombre;
                FilaEnDb.Active = true;
                db.Add(FilaEnDb);
                db.SaveChanges();
            }
            else
            {
                var consulta = (from d in db.Directors
                                where d.Id == items.id
                                select d).FirstOrDefault();
                consulta.Name = items.nombre;
                db.SaveChanges();
            }

        }


    }
}
