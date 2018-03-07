using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Team : BaseEntity
    {
        [Key]
        public int IdTeam { get; set; }

        public string Name { get; set; }
    }
}