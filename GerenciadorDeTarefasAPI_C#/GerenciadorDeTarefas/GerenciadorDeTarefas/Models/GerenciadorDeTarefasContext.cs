using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeTarefas.Models
{
    public class GerenciadorDeTarefasContext : DbContext
    {
        //configuracao de opçoes 
        public GerenciadorDeTarefasContext(DbContextOptions<GerenciadorDeTarefasContext> options) : base(options)
        {

        }

        //mapear cada model que deve virar uma tabela
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Tarefa> Tarefa { get; set; }
    }
}
