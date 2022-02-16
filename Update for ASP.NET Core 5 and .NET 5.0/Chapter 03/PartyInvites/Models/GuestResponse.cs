using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models {

    public class GuestResponse {

        [Display(Name="User Name")]
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Display(Name="User Email")]
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string Email { get; set; }
        
        [Display(Name="Phone Number")]
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }

        //a BOOL value will work with checkBOX Html control
        
        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public bool? WillAttend { get; set; }
    }
}
