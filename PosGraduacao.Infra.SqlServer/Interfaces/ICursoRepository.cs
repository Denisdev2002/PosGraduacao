using PosGraduacao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosGraduacao.Infra.SqlServer.Interfaces
{
    public interface ICursoRepository
    {
        public List<Curso> GetCurso();
        public Curso GetCursoById(int id);
        public void InsertCurso(Curso curso);
        public void UpdateCurso(Curso curso);
        public void DeleteCurso(Curso curso);
    }
}
