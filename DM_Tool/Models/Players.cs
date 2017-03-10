using DM_Tool.DAL;
using System.ComponentModel.DataAnnotations;
namespace DM_Tool.Models
{
    public class Players : GMToolDB_Context
    {
        [Key]
        public int playerID { get; set; }
        [StringLength(25, MinimumLength = 2)]
        [Required]
        public string name { get; set; }
        [StringLength(25, MinimumLength = 2)]
        [Required]
        public string race { get; set; }
        [Range(1,100)]
        [Required]
        public int level { get; set; }
        [Range(1, 100000)]
        [Required]
        public int hitpoints { get; set; }
        [Range(1, 100)]
        [Required]
        public int accuracy { get; set; }
        [Range(1, 100)]
        [Required]
        public int strength { get; set; }
        [Range(1, 100)]
        [Required]
        public int dexterity { get; set; }
        [Range(1, 100)]
        [Required]
        public int concentration { get; set; }
        [Range(1, 100)]
        [Required]
        public int intelligence { get; set; }
        [Range(1, 100)]
        [Required]
        public int wisdom { get; set; }
        [Range(1, 100)]
        [Required]
        public int charisma { get; set; }
        [StringLength(10, MinimumLength = 2)]
        [Required]
        public string initiative { get; set; }
        [StringLength(10, MinimumLength = 2)]
        [Required]
        public string speed { get; set; }



    }
}