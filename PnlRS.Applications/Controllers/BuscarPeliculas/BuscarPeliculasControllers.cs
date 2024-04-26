using PnlRS.Data.Data;
using PnlRS.Domain.Entities.BuscarPeliculas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnlRS.Applications.Controllers.BuscarPeliculas
{
    public class BuscarPeliculasControllers
    {
        public List<RespuestaBuscarPeliculas> Buscar()
        {
            var db = new MoviesDbContext();

            var consulta = from f in db.Films
                           join dir in db.Directors on f.DirectorId equals dir.Id
                           join std in db.Studios on f.StudioId equals std.Id
                           select new RespuestaBuscarPeliculas
                           {
                               IdPelicula = f.Id,
                               PeliculaNombre = f.Name,
                               FechaEstreno = f.ReleaseDate,
                               DirectorId = f.DirectorId,
                               DirectorNombre = dir.Name,
                               ResumenPelicula = f.Synopsis,
                               CantidadDeNominaciones = f.OscarNominations,
                               CantidadDePremios = f.OscarWins,
                               StudioId = f.StudioId,
                               StudioNombre = std.Name,
                                                          
                           };
            var resultado = consulta.ToList();
            return resultado;


        }
    }
}
