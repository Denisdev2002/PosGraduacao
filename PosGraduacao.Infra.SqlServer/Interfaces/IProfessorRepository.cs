using PosGraduacao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosGraduacao.Infra.SqlServer.Interfaces
{
    public interface IProfessorRepository
    {
        public List<Professor> GetProfessores();
        public Professor GetProfessorById(int id);
        public void InsertProfessor(Professor professor);
        public void UpdateProfessor(Professor professor);
        public void DeleteProfessor(Professor professor);
    }
}
