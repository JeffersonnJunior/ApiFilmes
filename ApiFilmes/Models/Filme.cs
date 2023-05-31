using System.ComponentModel.DataAnnotations;

namespace ApiFilmes.Models;

public class Filme
{

    [Key]
    [Required]
    public int Id { get; set; }

    [Required(ErrorMessage ="O título é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage ="O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage ="O tamanho máximo é 50 caracter")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage ="A duração máxima é de 70 a 600 minutos")]
    public int Duracao { get; set; }
    public virtual ICollection<Sessao> Sessoes { get; set; }

}
