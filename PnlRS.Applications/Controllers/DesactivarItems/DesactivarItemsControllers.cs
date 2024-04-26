using PnlRS.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnlRS.Applications.Controllers.DesactivarItems
{
    public class DesactivarItemsControllers
    {
        public void BorrarGeneros(int id)
        {
            if(id != 0)
            {
                var db = new MoviesDbContext();

                var consulta= (from g in db.Genres
                               where g.Id == id
                               select g).FirstOrDefault();

                if(consulta.Active == true)
                {
                    consulta.Active = false;
                }
                else
                {
                    consulta.Active = true;
                }
                db.SaveChanges();

            }
        }


        public void BorrarEstudios(int id)
        {

            if(id  != 0)
            {
                var db = new MoviesDbContext();
                var consulta = (from e in db.Studios
                                where e.Id == id
                                select e).FirstOrDefault();
                if (consulta.Active == true)
                {
                    consulta.Active = false;
                }
                else
                {
                    consulta.Active = true;
                }
                db.SaveChanges();
            }

        }
        public void BorrarLanguajes(int id)
        {
            if (id != 0)
            {
                var db = new MoviesDbContext();
                var consulta = (from l in db.Languages
                                where l.Id == id
                                select l).FirstOrDefault();
                if (consulta.Active == true)
                {
                    consulta.Active = false;
                }
                else
                {
                    consulta.Active = true;
                }
                db.SaveChanges();
            }
        }
        public void BorrarPais(int id)
        {
            if (id != 0)
            {
                var db = new MoviesDbContext();
                var consulta = (from p in db.Countries
                                where p.Id == id
                                select p).FirstOrDefault();
                if (consulta.Active == true)
                {
                    consulta.Active = false;
                }
                else
                {
                    consulta.Active = true;
                }
                db.SaveChanges();
            }
        }
        public void BorrarCertificados(int id)
        {
            if (id != 0)
            {
                var db = new MoviesDbContext();
                var consulta = (from c in db.Certificates
                                where c.Id == id
                                select c).FirstOrDefault();
                if (consulta.Active == true)
                {
                    consulta.Active = false;
                }
                else
                {
                    consulta.Active = true;
                }
                db.SaveChanges();
            }
        }
        public void BorrarActores(int id)
        {
            if (id != 0)
            {
                var db = new MoviesDbContext();
                var consulta = (from a in db.Actors
                                where a.Id == id
                                select a).FirstOrDefault();
                if (consulta.Active == true)
                {
                    consulta.Active = false;
                }
                else
                {
                    consulta.Active = true;
                }
                db.SaveChanges();
            }
        }
        public void BorrarAudiciones(int id)
        {
            if (id != 0)
            {
                var db = new MoviesDbContext();
                var consulta = (from c in db.Castings
                                where c.Id == id
                                select c).FirstOrDefault();
                if (consulta.Active == true)
                {
                    consulta.Active = false;
                }
                else
                {
                    consulta.Active = true;
                }
                db.SaveChanges();
            }
        }
        public void BorrarDirectores(int id)
        {
            if (id != 0)
            {
                var db = new MoviesDbContext();
                var consulta = (from d in db.Directors
                                where d.Id == id
                                select d).FirstOrDefault();
                if (consulta.Active == true)
                {
                    consulta.Active = false;
                }
                else
                {
                    consulta.Active = true;
                }
                db.SaveChanges();
            }
        }

    }
}
