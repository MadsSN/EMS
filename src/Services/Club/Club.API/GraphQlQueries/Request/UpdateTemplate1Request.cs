using System.ComponentModel.DataAnnotations;

namespace EMS.Club_Service.API.Controllers.Request
{
    /// <summary>
    /// Update club request
    /// </summary>
    public class UpdateClubRequest
    {
        [Required]
        [MaxLength(25)]
        public string Name { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(8)]
        [MinLength(8)]
        public string PhoneNumber { get; set; }
        [Required]
        [MaxLength(4)]
        [MinLength(4)]
        public string RegistrationNumber { get; set; }
        [Required]
        [MaxLength(8)]
        [MinLength(8)]
        public string AccountNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string Address { get; set; }
    }
}
