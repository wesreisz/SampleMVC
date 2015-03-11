using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVC.Models
{
    public class StudentViewModel
    {
        public Student student { get; set; }
        public List<String> States { get; set; }
    }
}