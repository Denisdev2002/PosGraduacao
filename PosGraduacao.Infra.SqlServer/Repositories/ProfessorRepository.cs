using PosGraduacao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosGraduacao.Infra.SqlServer.Repositories
{
    public class ProfessorRepository
    {
        private readonly SqlContext _context;

        public ProfessorRepository(SqlContext context)
        {
            _context = context;
        }
        public List<Professor> GetProfessors()
        {
            return _context.Professors.ToList();
        }
        public Professor GetProfessorById(int id)
        {
            return _context.Professors.Find(id);
        }
        public void InsertProfessor(Professor professor)
        {
            _context.Professors.Add(professor);
            _context.SaveChanges();
        }
        public void UpdateProfessor(Professor professor)
        {
            _context.Professors.Update(professor);
            _context.SaveChanges();
        }
        public void DeleteProfessor(Professor professor)
        {
            _context.Professors.Remove(professor);
            _context.SaveChanges();
        }
    }
}
