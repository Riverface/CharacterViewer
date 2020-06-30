using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Viewer.Models
{
    public class Character
    {
        public int CharacterId { get; set; }

        public string Faction { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Might { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Spryness { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Judgement { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Echo { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Magnetism { get; set; }
        [Required]
        [Range(1, 20, ErrorMessage = "Stats go from 1 to 20.")]
        public int Fortune { get; set; }
        [Required]

        [Range(1, 20)]
        public int Level { get; set; }
        public int experience { get; set; }

        public ICollection<CharacterTrait> Traits { get; set; }
    }
}