using System.ComponentModel.DataAnnotations;

namespace WebApplication6.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Campo obrigatório.")]
        [StringLength(70, ErrorMessage ="Digite até 70 caracteres.")]
        public string Nome { get; set; }
        [Required(ErrorMessage ="Campo obrigatório.")]
        [StringLength(11, MinimumLength = 11, ErrorMessage ="Digite exatamente 11 caracteres.")]
        public string CPF { get; set; }
        public string? Nacionalidade { get; set; }
        public string? Naturalidade { get; set; }
        public DateTime DataCad { get; set; }
        public bool Ativo { get; set; }
    }
}
