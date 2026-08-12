using System.ComponentModel.DataAnnotations;

namespace SalesCET108.Web.Data.Entities
{
    public class State
    {
        public int Id { get; set; }

        [Display(Name = "Estado/Província")]
        [MaxLength(50, ErrorMessage = "O campo {0} deve ter no máximo {1} caracteres!")]
        [Required(ErrorMessage = "O Campo {0} é obrigatório!")]
        public string? Name { get; set; }

        public int CountryId { get; set; }

        public Country? Country { get; set; }

        public ICollection<City> Cities { get; set; }

        public int CitiesNumber
        {
            get
            {
                return Cities == null ? 0 : Cities.Count;
            }
        }
    }
}