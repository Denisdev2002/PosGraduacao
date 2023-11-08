using PosGraduacao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosGraduacao.Infra.SqlServer.Interfaces
{
    public interface IDisciplinaRepository
    {
        public List<Disciplina> GetDisciplina();
        public Disciplina GetDisciplinaById(int id);
        public void InsertDisciplina(Disciplina disciplina);
        public void UpdateDisciplina(Disciplina disciplina);
        public void DeleteDisciplina(Disciplina discplina);
    }
}
