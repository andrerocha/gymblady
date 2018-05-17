using System.ComponentModel.DataAnnotations;

namespace Entities.Enum
{
    public enum BloodType: byte
    {
        [Display(Description = "AB Positivo")]
        PositiveAB = 1,

        [Display(Description = "AB Negativo")]
        NegativeAB = 2,

        [Display(Description = "O Positivo")]
        PositiveO = 3,

        [Display(Description = "O Negativo")]
        NegativeO = 4
    }
}
