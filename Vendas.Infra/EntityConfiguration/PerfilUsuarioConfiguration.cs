﻿using System.Data.Entity.ModelConfiguration;
using Vendas.Domain;

namespace Vendas.Infra.EntityConfiguration
{
    public class PerfilUsuarioConfiguration: EntityTypeConfiguration<PerfilPessoaUsuario>
    {
        public PerfilUsuarioConfiguration()
        {
            HasKey(p => new { p.IdPerfil, p.IdPessoaUsuario });

            HasRequired(p => p.Perfil)
                .WithMany()
                .HasForeignKey(p => p.IdPerfil);

            HasRequired(p => p.Usuario)
                .WithMany()
                .HasForeignKey(p => p.IdPessoaUsuario);
        }
    }
}
