using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using GestionDeCV.Enum;
namespace GestionDeCV.Models
{
    public class CandidateGeneralnfo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Nombre del Candidato es requerido")]
        [StringLength (60)]
        [MinLength(3, ErrorMessage = "Por favor ingrese un nombre válido")]
        [Display(Name = "Primer Nombre")]
        public string FirstName { get; set; }


        [StringLength (60)]
        [Display(Name = "Segundo Nombre")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Apellidos del Candidato es requerido")]
        [StringLength (60)]
        [MinLength(4, ErrorMessage = "Por favor ingrese un apellido válido")]
        [Display(Name = "Apellidos")]
        public string LastName { get; set; }


        [Required(ErrorMessage = "Número de Documento de identidad es requerido")]
        [StringLength(30)]
        [MinLength(8, ErrorMessage ="Por favor ingrese un número de identidad válido")]
        [Display(Name = "Documento de Identidad")]

        public string DocumentId { get; set; }

        [Required(ErrorMessage ="Fecha de nacimiento es requerido")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "País de Nacimiento es requerido")]
        [StringLength (40)]
        [MinLength(4, ErrorMessage ="Ingrese un Páis válido")]
        [Display(Name = "País de Nacimiento")]
        public string CountryOfBirth { get; set; }

        [Required(ErrorMessage ="Ciudad de Nacimiento es requerida")]
        [StringLength (60)]
        [MinLength(4, ErrorMessage = "Ingrese una ciudad de nacimiento válida")]
        [Display(Name = "Ciudad de Nacimiento")]
        public string CityOfBirth { get; set; }

        [StringLength (15)]
        [Display(Name = "No. Teléfono Fijo")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage ="El número de celular es requerido")]
        [StringLength (15)]
        [MinLength(8, ErrorMessage ="Ingrese un número de celular válido")]
        [Display(Name = "No. Celular")]
        public string CellPhoneNumner { get; set; }

        [Required(ErrorMessage = "Dirección de casa de habitación es requerido")]
        [StringLength (100)]
        [MinLength(10, ErrorMessage = "Ingrese una dirección válida.")]
        [Display(Name = "Dirección 1")]       
        public string Address1 { get; set; }


        
        [StringLength(100)]
        [Display(Name = "Dirección 2")]
        public string Address2 { get; set; }


        [Required(ErrorMessage ="Ciudad de casa de habitación es requerido")]
        [StringLength (40)]
        [MinLength(4, ErrorMessage ="Ingrese un nombre de ciudad valido")]
        [Display(Name = "Ciudad")]
        public string AddressCity { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un departamento")]
        [Display(Name = "Departamento")]
        public EnumAddressDepartment AddressDepartment { get; set; }

       
        [Required(ErrorMessage = "Correo Electronico es requerido")]
        [StringLength(150)]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string email { get; set; }

        [Required(ErrorMessage = "Puesto de Trabajo es requerido")]
        [StringLength(40)]
        [MinLength(4, ErrorMessage = "Ingrese el puesto de Trabajo valido")]
        [Display(Name = "Puesto de Trabajo Deseado")]
        public string PuestoTra { get; set; }


        public DateTime RecordSysTime { get => DateTime.Now;}


        [Display(Name = "Fotografia Reciente")]
        public byte[] Photo { get; set; }
    }

}