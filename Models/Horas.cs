using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTE.Models
{
    public class Horas
    {
        [Column("idHoras")]
        public int IdHoras { get; set; }

        [Column("idUsuario")]
        public int IdUsuario { get; set; }

        [Column("codigoWbs")]
        public int CodigoWbs { get; set; }

        [Column("datas")]
        public DateTime Datas { get; set; }

        [Column("horas")]
        public TimeSpan HorasTrabalhadas { get; set; }

        // Propriedade de navegação para Usuario
        public Usuario? Usuario { get; set; }

        // Propriedade de navegação para Wbs
        public Wbs? Wbs { get; set; }
    }
}
