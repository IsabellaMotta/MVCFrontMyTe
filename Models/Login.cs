using System.ComponentModel.DataAnnotations.Schema;

namespace MyTE.Models
{
    public class Login
    {
        [Column("idLogin")]
        public int IdLogin { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("senha")]
        public string Senha { get; set; }

        [Column("idUsuario")]
        public int IdUsuario { get; set; }

        public Usuario? Usuario { get; set; }
    }
}
