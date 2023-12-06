using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SegundoExamen.Herramientas;
using SegundoExamen.Models;

namespace SegundoExamen.Controllers
{
    [Route("sesion")]
    public class SesionController1 : Controller
    {
        [Route("sesion")]
        // GET: SesionController1
        public ActionResult Index()
        {
            HttpContext.Session.SetInt32("edad", 19);
            HttpContext.Session.SetString("usuario", "Pepe");
            // Ahora con objetos
            Producto prod = new Producto
            {
                Id = "QS001",
                Nombre = "Queso menonita",
                Precio = (Decimal)30.6
            };
            Conversor.ObjetoAjson(HttpContext.Session, "producto", prod);
            List<Producto> prods = new List<Producto>() {
                new Producto
                {
                    Id = "PR01",
                    Nombre = "Atun",
                    Precio = (Decimal)10.8
                },
                new Producto
                {
                    Id = "PR02",
                    Nombre = "Sardina",
                    Precio = (Decimal)20.5
                },
                new Producto
                {
                    Id = "PR03",
                    Nombre = "Helado",
                    Precio = (Decimal)13.4
                }
            };
            Conversor.ObjetoAjson(HttpContext.Session, "productos", prods);
            return View();
        }

        // GET: SesionController1/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        //// GET: SesionController1/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: SesionController1/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: SesionController1/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: SesionController1/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: SesionController1/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: SesionController1/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
