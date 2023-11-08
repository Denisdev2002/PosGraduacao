using PosGraduacao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosGraduacao.Domain.ViewModel
{
    public class DisciplinaViewModel
    {
        public string Id { get; set; }
        public string? NomeDisciplina { get; set; }
        public int? professorId { get; set; }
        public int? cursoId { get; set; }
    }
}
