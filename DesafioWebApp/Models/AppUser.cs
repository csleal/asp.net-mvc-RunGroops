namespace DesafioWebApp.Models;

public class AppUser
{
    public int? Pace { get; set; }
    public int? Quilometragem { get; set; }
    public Endereco? Endereco { get; set; }
    public ICollection<Club> Clubs { get; set; }
    public ICollection<Corrida> Corridas { get; set; }
}