using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Phase : Base
    {
        public string Nome { get; set; }
        public bool Status { get; set; }
        public Test Test { get; set; }
        public List<Test> ListTest { get; set; }
    }
}
