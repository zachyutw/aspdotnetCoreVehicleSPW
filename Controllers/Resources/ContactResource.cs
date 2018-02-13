using System.ComponentModel.DataAnnotations;

namespace aspdotnetblog.Controllers.Resources
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