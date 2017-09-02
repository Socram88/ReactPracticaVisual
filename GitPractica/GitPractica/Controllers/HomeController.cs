using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitPractica.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public JsonResult ObtenerPeliculas()
        {

            List<Peliculas> lista = new List<Peliculas>();

            Random r = new Random();

            string[] nombre = new string[] { "Polnareff", "Urahara", "Madara", "Trapito", "Antena", "Ginsan", "Kuroro", "Bankai" };
            string[] descripcion = new string[] {"This midsized city is overcrowded.  It stands in a deep valley and is mainly constructed of timber.  It is defended by an elite band of mercenaries, and its most noteworthy feature is the series of elaborate fountains.",
                "This vast, sparsely populated city near the coast is best known as a playground for the wealthy.  The majority of its inhabitants are involved in smuggling, and it is considered notable for its eclectic architectural style.",
                "This fairly large city is curiously empty.  It stands on the fringes of civilization and is mainly constructed of red brick.  It is defended by arcane spells, and its most noteworthy feature is the colorful tiled roofs." };


            string[] uriImagen = new string[] {"null",
                "https://www.stockvault.net/data/2014/03/23/154983/preview16.jpg",
                "https://thumb1.shutterstock.com/display_pic_with_logo/1606841/541616743/stock-photo-volcano-concepcion-from-ometepe-island-in-the-lake-cocibolca-nicaragua-541616743.jpg",
                "https://www.stockvault.net/data/2009/07/07/109343/preview16.jpg",
                "https://thumb7.shutterstock.com/display_pic_with_logo/3063263/599536064/stock-photo-ometepe-island-volcano-nicaragua-599536064.jpg",
                "https://thumb1.shutterstock.com/display_pic_with_logo/1259743/590760020/stock-photo-colourful-flowers-pictured-in-front-of-apoyo-lagoon-in-nicaragua-590760020.jpg",
                "null",
                "https://cdn.pixabay.com/photo/2014/05/08/15/37/cinque-terre-340348_960_720.jpg" };

            for(var i=0; i<r.Next(2,18); i++)
            {
                lista.Add(new Peliculas {
                    Nombre = "" + nombre[r.Next(0, nombre.Length-1)],
                    Descripcion = "" + descripcion[r.Next(0, descripcion.Length - 1)],
                    Anio = "" + DateTime.Now.ToString(),
                    UriImagen = "" + uriImagen[r.Next(0,uriImagen.Length-1)]
                });
            }


            return Json(new {
                ListaPeliculas = lista
            }, JsonRequestBehavior.AllowGet);


        }

        public class Peliculas
        {
            public string Nombre { get; set; }

            public string Descripcion { get; set; }

            public string Anio { get; set; }

            public string UriImagen { get; set; }

        }

    }


    
}