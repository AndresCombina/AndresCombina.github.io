using Microsoft.AspNetCore.Mvc.Rendering;
using PnlRS.Data.Data;

namespace AndresCombinaFinal.Models.ListItems
{
    public class CreandoPeliculas : Film
    {
        public IEnumerable<SelectListItem> ListEstudios { get; set; }
        public IEnumerable<SelectListItem> ListLenguajes { get; set; }
        public IEnumerable<SelectListItem> ListPaises { get; set; }
        public IEnumerable<SelectListItem> ListCertificados { get; set; }
        public IEnumerable<SelectListItem> ListDirectores { get; set; }
        public IEnumerable<SelectListItem> ListGeneros { get; set; }

    }
}
