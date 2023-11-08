using Microsoft.EntityFrameworkCore;
using PosGraduacao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosGraduacao.Infra.SqlServer
{
    public class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AdmMasterDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().ToTable("Aluno");
            modelBuilder.Entity<Curso>().ToTable("Curso");
            modelBuilder.Entity<Professor>().ToTable("Professor");
            modelBuilder.Entity<Disciplina>().ToTable("Discilina");


        }
        public DbSet<Aluno>? Alunos { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
        public DbSet<Professor>? Professors { get; set; }
        public DbSet<Disciplina>? Disciplinas { get; set; }


    }
}
