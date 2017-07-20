namespace Vendas.Domain
{
    public class PerfilUsuario
    {
        public int IdPerfil { get; set; }
        public int IdUsuario { get; set; }

        public virtual Perfil Perfil { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
