using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTE.Models
{
    public class Usuario
    {
        [Column("idUsuario")]
        public int IdUsuario { get; set; }

        [Column("nomeUsuario")]
        public string NomeUsuario { get; set; }

        [Column("dataNascimento")]
        public DateTime DataNascimento { get; set; }

        [Column("idDepartamento")]
        public int IdDepartamento { get; set; }

        [Column("tipo")]
        public int Tipo { get; set; }


        // Propriedade de navegação para Departamento
        public Departamento? Departamento { get; set; }

        // Propriedade de navegação para Horas
        public ICollection<Horas>? Horas { get; set; }

        // Propriedade de navegação para Login
        public ICollection<Login>? Logins { get; set; }
    }
}
