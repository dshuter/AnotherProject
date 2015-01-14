using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace AnotherProject.Models
{
    public class BlogModel
    {
        public string ID {get; set;}
        public string BlogTitle { get; set; }
        public string BlogPost { get; set; }
        public bool blogEdit { get; set; }

    }
}