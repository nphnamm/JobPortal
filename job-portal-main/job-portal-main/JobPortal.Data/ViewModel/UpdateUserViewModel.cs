using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace JobPortal.Data.ViewModel
{
    public class UpdateUserViewModel
    {
        [EmailAddress]
        [Display(Name = "Email account login")]
        public string? Email { get; set; }

        [Display(Name = "Company name")]
        [StringLength(100, ErrorMessage = "Company name cannot be more than 100 characters.")]
        public string? FullName { get; set; }
        [Display(Name = "Company overview")]
        public string? Description { get; set; }
        [Display(Name = "Company contact")]
   
        public IFormFile? UrlAvatar { get; set; }
        [Display(Name = "Location")]
 

    
        public string? Phone { get; set; }
        public int? Age { get; set; }




    }
}
