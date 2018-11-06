using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FAQApplication.Models
{
    public class UserQuestionsDomain
    {
        public int Id { get; set; }
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