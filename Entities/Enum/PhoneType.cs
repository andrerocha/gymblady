using System.ComponentModel.DataAnnotations;

namespace Entities.Enum
{
    public enum PhoneType : byte
    {
        [Display(Description = "Residencial")]
        Home = 1,

        [Display(Description = "Celular")]
        Cellphone = 2,

        [Display(Description = "Comercial")]
        Commercial = 3
    }
}