using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Criteria : Base
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public List<Test> ListTest { get; set; }
    }
}
