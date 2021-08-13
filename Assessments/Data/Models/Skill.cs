using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Skill : Base
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public byte Grade { get; set; }
        public Test Test { get; set; }
        public List<Test> ListTest { get; set; }
    }
}
