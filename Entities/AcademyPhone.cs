using Entities.Enum;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class AcademyPhone : BaseEntity
    {
        [Key]
        public int IdAcademyPhone { get; set; }

        public int IdAcademy { get; set; }

        public Academy Academy { get; set; }

        public PhoneType Type { get; set; }

        public int CountryCode { get; set; }

        public int AreaCode { get; set; }

        public string Number { get; set; }
    }
}