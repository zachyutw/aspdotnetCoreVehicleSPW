using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace aspdotnetblog.Models
{
    [Table("Models")]
    public class Model
    {
        public int id { get; set; }
        [Required]
        [StringLength(255)]
        public string name { get; set; }
        public Make Make { get; set; }
        //foreign key property
        public int MakeId { get; set; }
    }
}