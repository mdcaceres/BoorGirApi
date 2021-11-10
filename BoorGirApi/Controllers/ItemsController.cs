using LibraryBoorGir.DATA.Factory;
using LibraryBoorGir.DATA.servicios;
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
    public class ItemsController : ControllerBase
    {
        private IAplicacion app; 

        public ItemsController()
        {
            app = new Aplicacion(new Factory());
        }

        [HttpGet("/Barrios")]
        public ActionResult GetBarrios()
        {
            return Ok(app.TraerBarrios());
        }

        [HttpGet("/Pagos")]
        public ActionResult GetPagos()
        {
            return Ok(app.TraerPagos());
        }
    }
}
