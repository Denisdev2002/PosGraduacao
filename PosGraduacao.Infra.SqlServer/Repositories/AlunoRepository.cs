using PosGraduacao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosGraduacao.Infra.SqlServer.Repositories
{
    public class AlunoRepository
    {
        private readonly SqlContext _context;

        public AlunoRepository(SqlContext context)
        {
            _context = context;
        }
        public List<Aluno> GetAluno()
        {
            return _context.Alunos.ToList();
        }
        public Aluno GetAlunoById(int id)
        {
            return _context.Alunos.Find(id);
        }
        public void InsertAluno(Aluno aluno)
        {
            _context.Alunos.Add(aluno);
            _context.SaveChanges();
        }
        public void UpdateAluno(Aluno aluno)
        {
            _context.Alunos.Update(aluno);
            _context.SaveChanges();
        }
        public void DeleteAluno(Aluno aluno)
        {
            _context.Alunos.Remove(aluno);
            _context.SaveChanges();
        }
    }
}
