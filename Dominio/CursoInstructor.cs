using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class CursoInstructor
    {
        public int CursoId { get; set; }
        public int InstructorId { get; set; }
        public Instructor tblInstructor { get; set; }
    }
}
