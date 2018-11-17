using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FAQApplication.Models
{
    public class UserQuestionsDomain
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9_ ?!]{10,150}$")]
        public string Question { get; set; }
        public int Rating { get; set; }
    }
    
    public class FAQDomain
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}