using LibraryBoorGir.DATA.Factory;
using LibraryBoorGir.DATA.servicios;
using LibraryBoorGir.Entidades;
using LibraryBoorGir.servicios;
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
    public class ClientesController : ControllerBase
    {
        private IAplicacion app;

        public ClientesController()
        {
            app = new Aplicacion(new Factory());
        }

        [HttpGet("/Clientes")]
        public ActionResult GetClientes()
        {
            return Ok(app.ConsultarClientes()); 
        }

        [HttpGet("/ClientesPorFiltro")]
        public ActionResult GetClientesFiltrado(int dni)
        {
            return Ok(app.ConsultarClientes(dni));
        }

        [HttpPost]
        public IActionResult Post(Clientes cliente)
        {
            if (cliente == null)
            {
                return BadRequest("no mando el cliente");
            }
            app.CrearCliente(cliente);
            return Ok("Se registro existosamente");
        }
    }
}
