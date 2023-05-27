using System.ComponentModel.DataAnnotations;
using Empleos_SA_SV.Models;

namespace Empleos_SA_SV.Models
{
    public class empleo
    {
        [Key]

        [Display(Name = "ID")]

        public int empleoID { get; set; }
        [Display(Name = "Nombre del empleo")]

        public string? empleos { get; set; }
        [Display(Name = "Empleos")]

        public decimal salario { get; set; }



    }
}
