using Microsoft.EntityFrameworkCore;
using SocorroDesk.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace SocorroDesk.Database
{
    public class SocorroDeskContext : DbContext
    {
        public SocorroDeskContext(DbContextOptions<SocorroDeskContext> options) : base(options)
        {
        }

        public DbSet<Chamado> Chamados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var chamado = modelBuilder.Entity<Chamado>();

            //Config Tabela
            chamado.ToTable("TB_CHAMADOS");
            chamado.HasIndex(x => x.Id).IsUnique().HasDatabaseName("IX_ID_UNIQUE");
            chamado.HasKey(x => x.Id);


            //Propriedades
            chamado.Property(x => x.DataAbertura).HasColumnName("DATA_ABERTURA").IsRequired();
            chamado.Property(x => x.Chapa).HasColumnName("CHAPA_COLABORADOR").IsRequired();
            chamado.Property(x => x.Departamento).HasColumnName("DEPARTAMENTO").IsRequired();
            chamado.Property(x => x.Assunto).HasColumnName("ASSUNTO").IsRequired();
            chamado.Property(x => x.UltimaAtualizacao).HasColumnName("ULTIMA_ATUALIZAÇÃO").IsRequired();
            chamado.Property(x => x.Status).HasColumnName("STATUS").IsRequired();
            chamado.Property(x => x.Observacoes).HasColumnName("OBSERVACOES");

            //SEEDS
            chamado.HasData
                (
                    new Chamado { Id = 1, Assunto = "Suporte de Hardware", },
                    new Chamado { Id = 2, Assunto = "Problemas com Login e Senha", },
                    new Chamado { Id = 3, Assunto = "Outros", }
                );
        }
    }
}