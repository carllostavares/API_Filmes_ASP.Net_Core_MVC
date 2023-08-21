using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos;

public class UpdateFilmeDto
{

    [Required(ErrorMessage = "É obrigatório informar o  Título !")]
    [StringLength(50, ErrorMessage = "O tamanho do Título não pode exceder 50 caracteres !")]

    public string Titulo { get; set; }

    [Required(ErrorMessage = "É obrigatório informar o Genero !")]
    [StringLength(50, ErrorMessage = "O tamanho do Genero não pode exceder 50 caracteres !")]
    public string Genero { get; set; }

    [Required(ErrorMessage = "É obrigatório informar a Duração !")]
    [Range(70, 600, ErrorMessage = "O tamanho do Genero não pode exceder 50 caracteres !")]
    public int Duracao { get; set; }

}
