using DesafioWebApp.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioWebApp.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string? Titulo{ get; set; }
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }
        [ForeignKey("Endereco")]
        public int? EnderecoId { get; set; }
        public Endereco? Endereco { get; set; }
        public CategoriaClub CategoriaClub { get; set; }
        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}