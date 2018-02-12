using System.ComponentModel.DataAnnotations;

namespace aspdotnetblog.Controllers.Resources
{
    public partial class VehicleResource
    {
        public class ContactResource
        {
            [Required]
            [StringLength(255)]
            public string Name { get; set; }
            [Required]
            [StringLength(255)]
            public string Phone { get; set; }
            [Required]
            [StringLength(255)]
            public string Email { get; set; }
        }




    }
}