using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Country
    {
        [Key]
        public int IdCountry { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }        
    }
}