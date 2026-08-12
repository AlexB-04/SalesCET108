using System.ComponentModel.DataAnnotations;

namespace SalesCET108.Web.Data.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Display(Name = "Cidade")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres!")]
        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        public string? Name { get; set; }

        public int StateId { get; set; }

        public State? State { get; set; }
    }
}