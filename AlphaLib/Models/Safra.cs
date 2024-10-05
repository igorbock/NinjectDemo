using AlphaLib.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlphaLib.Models
{
    [Table("safras", Schema = "cadastros")]
    public class Safra : IEntity
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }
        public bool? Inativo { get; set; }
        public DateTime? DataInicial { get; set; }
        public DateTime? DataFinal { get; set; }
    }
}
