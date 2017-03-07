using System.ComponentModel.DataAnnotations;

namespace DM_Tool.Models
{
    public class Monsters
    {
        [Key]
        public int monsterID { get; set; }
        [StringLength(25, MinimumLength = 2)]
        [Required]
        public string monsterName { get; set; }
        [Range(1, 100000)]
        [Required]
        public int monsterHP { get; set; }
        [StringLength(25, MinimumLength = 2)]
        [Required]
        public string monsterDamage { get; set; }
        [Range(1, 100000)]
        [Required]
        public int experience { get; set; }



    }
}