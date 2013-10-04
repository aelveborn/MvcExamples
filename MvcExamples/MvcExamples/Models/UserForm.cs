using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcExamples.Models
{
    public class UserForm
    {
        public string Surname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Age { get; set; }
        public DateTime PostedDate { get; set; }
    }
}