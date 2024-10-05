using AlphaLib.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AlphaLib.Models
{
    [Table("carros", Schema = "cadastros")]
    public class Carro : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }

        public override string ToString() => $"{Marca} - {Modelo} - {Ano} - {Cor}";
    }
}
