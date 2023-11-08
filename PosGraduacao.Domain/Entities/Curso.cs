using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosGraduacao.Domain.Entities
{
    public class Curso
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int? duracao { get; set; }

    }
}
