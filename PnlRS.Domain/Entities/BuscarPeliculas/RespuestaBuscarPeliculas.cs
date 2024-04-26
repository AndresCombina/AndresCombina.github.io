using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnlRS.Domain.Entities.BuscarPeliculas
{
    public class RespuestaBuscarPeliculas
    {
        public int IdPelicula { get; set; }
        public string PeliculaNombre { get; set;}

        public DateTime? FechaEstreno { get; set; }

        public int? DirectorId { get; set; }

        public string DirectorNombre { get; set;}

        public string ResumenPelicula { get; set; }

        public int Duracion { get; set; }

        public int CantidadDeNominaciones { get; set; }

        public int CantidadDePremios { get; set; }

        public int? StudioId { get; set; }

        public string StudioNombre { get;set;}

        
        
    }
}
