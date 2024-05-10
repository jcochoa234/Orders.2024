namespace Orders.Shared.Entities
{
    using System.ComponentModel.DataAnnotations;

    public class Country
    {
        public Guid Id { get; set; }

        [Display(Name = "Pais")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        public string Name { get; set; } = null!;
    }
}