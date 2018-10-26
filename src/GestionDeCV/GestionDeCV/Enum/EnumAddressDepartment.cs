using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GestionDeCV.Enum
{
    public enum EnumEstadoCiv
    {
        [Display(Name = "Soltero (a)")]
        Soltero = 1,

        [Display(Name = "Casado (a)")]
        Casado = 2,

        [Display(Name = "Divorciado (a)")]
        Divorciado = 3,

        [Display(Name = "Viudo (a)")]
        Viudo = 4,

    }

    public enum EnumAddressDepartment
    {
        [Display(Name = "Cortes")]
        Cortes = 1,

        [Display(Name = "Santa Barbara")]
        SantaBarbara = 2,

        [Display(Name = "Atlántida")]
        Atlantida = 3,

        [Display(Name = "Colón")]
        Colon = 4,

        [Display(Name = "Comayagua")]
        Comayagua = 5,

        [Display(Name = "Copán")]
        Copan = 6,

        [Display(Name = "Choluteca")]
        Choluteca = 7,

        [Display(Name = "El Paraíso")]
        ElParaiso = 8,

        [Display(Name = "Francisco Morazán")]
        FranciscoMorazan = 9,

        [Display(Name = "Gracias a Dios")]
        GraciasADios = 10,

        [Display(Name = "Intibucá")]
        Intibuca = 11,

        [Display(Name = "Islas de la Bahía")]
        IslasDeLaBahia = 12,

        [Display(Name = "La Paz")]
        LaPaz = 13,

        [Display(Name = "Lempira")]
        Lempira = 14,

        [Display(Name = "Ocotepeque")]
        Ocotepeque = 15,

        [Display(Name = "Olancho")]
        Olancho = 16,

        [Display(Name = "Valle")]
        Valle = 17,

        [Display(Name = "Yoro")]
        Yoro = 18,
    }


   

}