using Dominio;
using Microsoft.AspNetCore.Mvc;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCore.Controllers
{
    [Route("api/[controller]")]
    public class CursosController:ControllerBase
    {
        private readonly CursosOnlineContext context;
        public CursosController(CursosOnlineContext _context)
        {
            this.context = _context;
        }

        [HttpGet]
        public IEnumerable<Curso> Get()
        {
            return context.tblCurso.ToList();
        }
    }
}
