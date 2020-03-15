using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FoodApp.ViewModel
{
    public class ContactViewModel
    {
        [StringLength(maximumLength:200,ErrorMessage ="between 3 and 200",MinimumLength =3)]
        public string ContactMessage { get; set; }
        [StringLength(maximumLength: 200, ErrorMessage = "between 3 and 200", MinimumLength = 3)]
        public string Name { get; set; }
        [StringLength(maximumLength: 200, ErrorMessage = "between 3 and 200", MinimumLength = 3)]
        public string Email { get; set; }
        [EmailAddress]
        public string ContactSubject { get; set; }
    }
}