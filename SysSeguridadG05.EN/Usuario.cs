using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
///******************************
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SysSeguridadG05.EN
{
    public class Usuario
    {

        [Key]

        public int Id { get; set; }
        [ForeignKey("Rol")]
        [Required(ErrorMessage = "Rol es Ogligatorio")]
        [Display(Name = "Rol")]

        public int IdRol { get; set; }
        [Required(ErrorMessage = "Nombre es Obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 Caracteres")]

        public int Nombre { get; set; }
        [Required(ErrorMessage = "Appelido es Obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 Caracteres")]

        public int Apellido { get; set; }
        [Required(ErrorMessage = "Login es Obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 Caracteres")]
        public int Login { get; set; }
        [Required(ErrorMessage = "Password es Obligatorio")]
        [DataType(DataType.Password)]
        [StringLength(32, ErrorMessage = "El Password debe estar 5 y 32 caracteres")]
        public int Password { get; set; }
        [Required(ErrorMessage = "Estatus es Obligatorio")]
        public byte Estatus { get; set; }
        [Display(Name = "Fecha de Registro")]

        public DateTime FechaRegistro { get; set; }
        public Rol Rol { get; set; }
        [NotMapped]

        public int Top_Aux { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Comfirmar Password")]
        [StringLength(32, ErrorMessage = "Password debe estar entre 5 a 32 caracteres")]
        [Compare("Pasword", ErrorMessage = "Paswor y comfirmar passwor deben ser iguales")]
        [Display(Name = "Confirmar Pasword")]

        public string ConfirmPassword_aux { get; set; }

    }
}
