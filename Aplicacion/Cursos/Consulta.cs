using MediatR;
using System;
using System.Text;
using System.Threading;
using Persistencia;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Dominio;

namespace Aplicacion.Cursos
{
    public class Consulta
    {
        public class ListaCursos : IRequest<List<Curso>> { }
        public class Manejador : IRequestHandler<ListaCursos, List<Curso>>
        {
            private readonly CursosOnlineContext _context;

            public Manejador(CursosOnlineContext context)
            {
                _context = context;
            }
            public async Task<List<Curso>> Handle(ListaCursos request, CancellationToken cancellationToken)
            {
                var cursos = await _context.tblCurso.ToListAsync();
                return cursos;
            }
        }
    }
}
