using System;
using System.Collections.Generic;

namespace Data.Models
{
    public class Test : Base
    {
        public string Name { get; set; }
        public float Time { get; set; }
        public DateTime RealizationDate { get; set; }
        public List<Assessment> Assessment { get; set; }
        public string Result { get; set; }
    }
}
