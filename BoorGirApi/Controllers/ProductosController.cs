using LibraryBoorGir.DATA.Factory;
using LibraryBoorGir.DATA.servicios;
using LibraryBoorGir.Entidades;
using LibraryBoorGir.servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoorGirApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private IAplicacion app;

        public ProductosController()
        {
            app = new Aplicacion(new Factory());
        }

        [HttpGet("/Productos")]
        public ActionResult GetProductos()
        {
            return Ok(app.TraerProductos());
        }

        //[HttpGet("/Productos2")]
        //public ActionResult GetProductosFiltrado(FormCollection frm)
        //{
        //    return Ok(app.TraerProductosFiltrado(frm["txtProducto"]));
        //}

        [HttpGet("/Productos2")]
        public ActionResult GetProductosFiltrado(string nombre)
        {
            return Ok(app.TraerProductos(nombre));
        }
    }
}
