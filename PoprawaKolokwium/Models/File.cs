using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoprawaKolokwium.Models
{
    public class File
    {
        [Key, Column(Order = 0)]
        public int FileID { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        public int TeamId { get; set; }

        [Required]
        [MaxLength(100)]
        public string FileName { get; set; }

        [Required]
        [MaxLength(4)]
        public string FileExtensions { get; set; }
        public int FileSize { get; set; }

        [ForeignKey("TeamId")]
        public Team Team { get; set; }


    }
}
