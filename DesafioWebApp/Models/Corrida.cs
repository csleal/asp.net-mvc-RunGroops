using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DesafioWebApp.Data.Enum;

namespace DesafioWebApp.Models;

public class Corrida
{
    [Key]
    public int Id { get; set; }
    public string? Titulo{ get; set; }
    public string? Descricao { get; set; }
    public string? Imagem { get; set; }
    [ForeignKey("Endereco")]
    public int? EnderecoId { get; set; }
    public Endereco? Endereco { get; set; }
    public CategoriaCorrida CategoriaCorrida { get; set; }
    [ForeignKey("AppUser")]
    public string? AppUserId { get; set; }
    public AppUser? AppUser { get; set; }
}