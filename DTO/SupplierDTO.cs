using System.ComponentModel.DataAnnotations;

namespace dotnet_sistema_delivery.DTO
{
    public class SupplierDTO
    {
        [Required]
        public long Id { get; set; }

        [Required(ErrorMessage="Nome do fornecedor é obrigatório.")]
        [StringLength(100, ErrorMessage="Nome do fornecedor com tamanho inválido.")]
        [MinLength(2, ErrorMessage="Nome do fornecedor deve possuir no mínimo 2 caracteres.")]
        public string name { get; set; }

        [Required(ErrorMessage="E-mail é obrigatório.")]
        [EmailAddress(ErrorMessage="E-mail inválido.")]
        public string email { get; set; }

        [Required(ErrorMessage="E-mail é obrigatório.")]
        [Phone(ErrorMessage="Telefone inválido.")]
        public string telephone { get; set; }
    }
}