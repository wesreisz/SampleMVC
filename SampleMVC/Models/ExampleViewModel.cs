using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleMVC.Models
{
    public class ExampleViewModel
    {
        public string String { get; set; }
        public decimal Decimal { get; set; }
        public bool Bool { get; set; }
        public DateTime DateTime { get; set; }
        public List<String> Names { get; set; }
        public List<Student> Students { get; set; }
    }
}