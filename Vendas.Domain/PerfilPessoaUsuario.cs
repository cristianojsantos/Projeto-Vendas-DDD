namespace Vendas.Domain
{
    public class PerfilPessoaUsuario
    {
        public int IdPerfil { get; set; }
        public int IdPessoaUsuario { get; set; }
        public int IdLoja { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual PessoaUsuario Usuario { get; set; }        
    }
}
