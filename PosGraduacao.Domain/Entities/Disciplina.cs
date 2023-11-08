using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosGraduacao.Domain.Entities
{
    public class Disciplina
    {
        public string Id { get; set; }
        public string? NomeDisciplina { get; set; }
        public List<Professor>? professors { get; set; }
        public List<Curso>? cursos { get; set; }
    }
}
