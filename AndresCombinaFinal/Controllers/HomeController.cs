using AndresCombinaFinal.Controllers.SelectItems;
using AndresCombinaFinal.Models;
using AndresCombinaFinal.Models.ListItems;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using PnlRS.Applications.Controllers.BuscarItems;
using PnlRS.Applications.Controllers.BuscarPeliculas;
using PnlRS.Applications.Controllers.CrearItems;
using PnlRS.Applications.Controllers.CrearPeliculas;
using PnlRS.Applications.Controllers.DesactivarItems;
using PnlRS.Applications.Controllers.ItemsCounts;
using PnlRS.Applications.Controllers.ModificandoItems;
using PnlRS.Data.Data;
using PnlRS.Domain.Entities.CrearItems;
using System.Diagnostics;

namespace AndresCombinaFinal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult IncioSesionForm()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult DatosPeliculas()

        {
            ItemsCounts p= new ItemsCounts();


            return View(p.DatosPeliculas());
        }

 



        #region Generos
        public IActionResult Directores(int DirectoresId)
        {
            BuscarItems d = new BuscarItems();
            DesactivarItemsControllers di = new DesactivarItemsControllers();
            di.BorrarDirectores(DirectoresId);
            return View(d.BuscarDirectores());
        }
        [HttpGet]
        public IActionResult DirectoresAbm(int DirectoresId)
        {
            ModificandoItemsControllers d = new ModificandoItemsControllers();
            return View(d.EditarDirectores(DirectoresId));
        }
        public IActionResult DirectoresAbm(NuevosItems items)
        {
            CrearItemControllers d = new CrearItemControllers();
            d.CrearDirectores(items);
            return Redirect("~/Home/Directores");
        }

        public IActionResult Audiciones(int AudicionesId)
        {
            BuscarItems a = new BuscarItems();
            DesactivarItemsControllers ad = new DesactivarItemsControllers();
            ad.BorrarAudiciones(AudicionesId);
            return View(a.BuscarAudiciones());
        }
        [HttpGet]
        public IActionResult AudicionesAbm(int AudicionesId)
        {
            ModificandoItemsControllers a = new ModificandoItemsControllers();
            return View(a.EditarAudiciones(AudicionesId));
        }
        public IActionResult AudicionesAbm(NuevosItems items)
        {
            CrearItemControllers a = new CrearItemControllers();
            a.CrearAudiciones(items);
            return Redirect("~/Home/Audiciones");
        }


        public IActionResult Actores(int ActoresId)
        {
            BuscarItems a = new BuscarItems();
            DesactivarItemsControllers ac = new DesactivarItemsControllers();
            ac.BorrarActores(ActoresId);
            return View(a.BuscarActores());
        }
        [HttpGet]
        public IActionResult ActoresAbm(int ActoresId)
        {
            ModificandoItemsControllers a = new ModificandoItemsControllers();
            return View(a.EditarActores(ActoresId));
        }
        public IActionResult ActoresAbm(NuevosItems items)
        {
            CrearItemControllers a = new CrearItemControllers();
            a.CrearActores(items);
            return Redirect("~/Home/Actores");
        }

        public IActionResult Certificados(int CertificadosId)
        {
            BuscarItems c = new BuscarItems();
            DesactivarItemsControllers ce=new DesactivarItemsControllers();
            ce.BorrarCertificados(CertificadosId);
            return View(c.BuscarCertificados());
        }
        [HttpGet]
        public IActionResult CertificadosAbm(int CertificadosId)
        {
            ModificandoItemsControllers c = new ModificandoItemsControllers();
            return View(c.EditarCertificados(CertificadosId));
        }
        public IActionResult CertificadosAbm(NuevosItems items)
        {
            CrearItemControllers c = new CrearItemControllers();
            c.CrearCertificados(items);
            return Redirect("~/Home/Certificados");
        }

        public IActionResult Pais(int PaisId)
        {
            BuscarItems p= new BuscarItems();
            DesactivarItemsControllers pa = new DesactivarItemsControllers();
            pa.BorrarPais(PaisId);
            return View(p.BuscarPais());
        }
        [HttpGet]
        public IActionResult PaisAbm(int PaisId)
        {
            ModificandoItemsControllers p = new ModificandoItemsControllers();
            return View(p.EditarPais(PaisId));
        }
        public IActionResult PaisAbm(NuevosItems items)
        {
            CrearItemControllers p = new CrearItemControllers();
            p.CrearPais(items);
            return Redirect("~/Home/Pais");
        }

        public IActionResult Languajes(int LanguajesId)
        {
            BuscarItems l= new BuscarItems();
            DesactivarItemsControllers le=new DesactivarItemsControllers();
            le.BorrarLanguajes(LanguajesId);
            return View(l.BuscarLanguajes());
        }
        [HttpGet]
        public IActionResult LanguajesAbm(int LanguajesId)
        {
            ModificandoItemsControllers l = new ModificandoItemsControllers();
            return View(l.EditarLanguajes(LanguajesId));
        }
        public IActionResult LanguajesAbm(NuevosItems items)
        {
            CrearItemControllers e = new CrearItemControllers();
            e.CrearLenguaje(items);
            return Redirect("~/Home/Languajes");
        }





        public IActionResult Estudios(int EstudioId)
        {
            BuscarItems e = new BuscarItems();
            DesactivarItemsControllers es=new DesactivarItemsControllers();
            es.BorrarEstudios(EstudioId);
            return View(e.BuscarEstudios());
        }
        [HttpGet]
        public IActionResult EstudiosAbm(int EstudioId)
        {
            ModificandoItemsControllers e= new ModificandoItemsControllers();
            return View(e.EditarEstudios(EstudioId));
        }
        public IActionResult EstudiosAbm(NuevosItems items)
        {
            CrearItemControllers e = new CrearItemControllers();
            e.CrearEstudios(items);
            return Redirect("~/Home/Estudios");
        }



        public IActionResult Generos(int GenerosId)
        {
            BuscarItems g = new BuscarItems();
            DesactivarItemsControllers ge = new DesactivarItemsControllers();
            ge.BorrarGeneros(GenerosId);
            return View(g.BuscarGeneros());
        }


        [HttpGet]
        public IActionResult GenerosAbm(int GenerosId)
        {

            ModificandoItemsControllers g = new ModificandoItemsControllers();
            return View(g.EditarGeneros(GenerosId));
        }
        public IActionResult GenerosAbm(NuevosItems items)
        {
            CrearItemControllers g = new CrearItemControllers();
            g.CrearGeneros(items);
            return Redirect("~/Home/Generos");

        }
        #endregion Generos

        public IActionResult Peliculas()
        {
            BuscarPeliculasControllers p = new BuscarPeliculasControllers();
            return View(p.Buscar());
        }
        [HttpGet]
        public IActionResult PeliculasAbm()
        {
            var modelo = new CreandoPeliculas();           
            ViewsItems v= new ViewsItems();
            modelo.ListCertificados = v.ListCertificados();
            modelo.ListEstudios = v.ListEstudio();
            modelo.ListLenguajes = v.ListLenguaje();
            modelo.ListPaises = v.ListPais();
            modelo.ListGeneros = v.ListGenero();
            return View(modelo);
        }
        public IActionResult PeliculasAbm(Film modelo)
        {
            CrearPeliculasControllers p = new CrearPeliculasControllers();
            p.CrearPelicula(modelo);
            return Redirect("~/Home/Peliculas");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}