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

namespace BoorGirApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        public IAplicacion app;
        public FacturasController()
        {
            app = new Aplicacion(new Factory());
        }
        [HttpPost]
        public IActionResult Post(Factura factura)
        {
            if (factura == null)
            {
                return BadRequest("no mando la facturta");
            }
            app.CrearFactura(factura); 
            return Ok("Se registro existosamente");
        }
    }
}
