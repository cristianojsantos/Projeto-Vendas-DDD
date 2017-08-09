﻿namespace Vendas.Domain
{
    public class PerfilPessoaUsuario
    {
        public int IdPerfil { get; set; }
        public int IdPessoa { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual PessoaUsuario Usuario { get; set; }
    }
}
