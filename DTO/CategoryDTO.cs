using System.ComponentModel.DataAnnotations;

namespace dotnet_sistema_delivery.DTO
{
    public class CategoryDTO
    {
        
        [Required]
        public int id {get; set;}

        [Required(ErrorMessage="Nome da categoria é obrigatório.")]
        [StringLength(100, ErrorMessage="Nome da categoria com tamanho inválido.")]
        [MinLength(2, ErrorMessage="Nome da categoria deve possuir no mínimo 2 caracteres.")]
        public string name { get; set; }
    }
}