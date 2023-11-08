using PosGraduacao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosGraduacao.Infra.SqlServer.Repositories
{
    public class DisciplinaRepository
    {
        private readonly SqlContext _context;

        public DisciplinaRepository(SqlContext context)
        {
            _context = context;
        }
        public List<Disciplina> GetDisciplinas()
        {
            return _context.Disciplinas.ToList();
        }
        public Curso GetCursoById(int id)
        {
            return _context.Cursos.Find(id);
        }
        public void InsertCurso(Curso curso)
        {
            _context.Cursos.Add(curso);
            _context.SaveChanges();
        }
        public void UpdateCurso(Curso curso)
        {
            _context.Cursos.Update(curso);
            _context.SaveChanges();
        }
        public void DeleteCurso(Curso curso)
        {
            _context.Cursos.Remove(curso);
            _context.SaveChanges();
        }
    }
}
