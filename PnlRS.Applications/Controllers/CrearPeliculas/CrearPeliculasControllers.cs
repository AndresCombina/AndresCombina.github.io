using PnlRS.Data.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnlRS.Applications.Controllers.CrearPeliculas
{
    public class CrearPeliculasControllers
    {
        public void CrearPelicula(Film Pelicula)
        {
            var db = new MoviesDbContext();

            var FilaEnDB = new Film();
            FilaEnDB.Active= true;
            FilaEnDB.BoxOfficeDollars = Pelicula.BoxOfficeDollars;
            FilaEnDB.BudgetDollars = Pelicula.BudgetDollars;
            FilaEnDB.CertificateId = Pelicula.CertificateId;
            FilaEnDB.CountryId = Pelicula.CountryId;
            FilaEnDB.LanguageId = Pelicula.LanguageId;
            FilaEnDB.DirectorId = Pelicula.DirectorId;
            FilaEnDB.StudioId = Pelicula.StudioId;
            FilaEnDB.Name= Pelicula.Name;
            FilaEnDB.RunTimeMinutes = Pelicula.RunTimeMinutes;
            FilaEnDB.Synopsis = Pelicula.Synopsis;
            FilaEnDB.ReleaseDate = Pelicula.ReleaseDate;
            FilaEnDB.OscarNominations = 0;
            FilaEnDB.OscarWins = 0;
            db.Films.Add( FilaEnDB );
            db.SaveChanges();

        }
    }
}
