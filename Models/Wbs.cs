using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyTE.Models
{
    public class Wbs
    {
        [Column("codigoWbs")]
        public int CodigoWbs { get; set; }

        [Column("nomeWbs")]
        public string? NomeWbs { get; set; }

        [Column("descricaoWbs")]
        public string? DescricaoWbs { get; set; }
        // Propriedade de navegação para Horas
        // O ICollection<Horas> define um relacionamento de um-para-muitos entre a entidade Wbs e a entidade Horas. Isso significa que uma Wbs pode ter muitas entradas de Horas associadas a ela.
        public ICollection<Horas>? Horas { get; set; }

        // Propriedades de navegação permitem que você navegue nas relações entre entidades. Por exemplo, você pode acessar todas as horas registradas para uma determinada Wbs diretamente através dessa propriedade.
        // EF Core usa essas propriedades de navegação para carregar entidades relacionadas automaticamente (quando configurado para isso). Isso é útil para consultas e operações CRUD onde as entidades relacionadas precisam ser acessadas ou manipuladas.

    }
}
