﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ImobToken.Domain
{
    [Table("TESTE")]
    public class Teste
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column("NOME")]
        public string Nome { get; set; }
        [Column("TIPO")]
        public string Tipo { get; set; }
    }
}
