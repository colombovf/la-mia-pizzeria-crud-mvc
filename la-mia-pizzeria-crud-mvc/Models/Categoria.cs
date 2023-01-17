
using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_crud_mvc.Models
{
    public class Categoria
    {
        [Key]
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }

        public Pizza Pizza { get; set;}
    }
}
