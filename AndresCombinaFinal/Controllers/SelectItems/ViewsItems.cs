using Microsoft.AspNetCore.Mvc.Rendering;

using PnlRS.Applications.Controllers.BuscarItems;

namespace AndresCombinaFinal.Controllers.SelectItems
{
    public class ViewsItems
    {


        public IEnumerable<SelectListItem> ListCertificados()
        {
            BuscarItems c= new BuscarItems();
            var lst= c.BuscarCertificados();

            var OpcionPorDefecto = new SelectListItem("--Seleccione una clasificacion--", "0", true);

            
            var resultado = lst.Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
            resultado.Insert(0, OpcionPorDefecto);
            return resultado;
        }
        public IEnumerable<SelectListItem> ListEstudio()
        {
            BuscarItems c = new BuscarItems();
            var lst = c.BuscarEstudios();

            var OpcionPorDefecto = new SelectListItem("--Seleccione un Estudio--", "0", true);


            var resultado = lst.Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
            resultado.Insert(0, OpcionPorDefecto);
            return resultado;
        }
        public IEnumerable<SelectListItem> ListPais()
        {
            BuscarItems c = new BuscarItems();
            var lst = c.BuscarPais();

            var OpcionPorDefecto = new SelectListItem("--Seleccione un Pais--", "0", true);


            var resultado = lst.Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
            resultado.Insert(0, OpcionPorDefecto);
            return resultado;
        }
        public IEnumerable<SelectListItem> ListLenguaje()
        {
            BuscarItems c = new BuscarItems();
            var lst = c.BuscarLanguajes();

            var OpcionPorDefecto = new SelectListItem("--Seleccione un Lenguaje --", "0", true);

            var resultado = lst.Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
            resultado.Insert(0, OpcionPorDefecto);
            return resultado;

        }
        public IEnumerable<SelectListItem> ListGenero()
        {
            BuscarItems c = new BuscarItems();
            var lst = c.BuscarGeneros();

            var OpcionPorDefecto = new SelectListItem("--Seleccione un Genero--", "0", true);


            var resultado = lst.Select(x => new SelectListItem(x.Name, x.Id.ToString())).ToList();
            resultado.Insert(0, OpcionPorDefecto);
            return resultado;
        }
    }
}
