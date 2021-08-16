using System.Collections.Generic;

namespace Data.Models
{
    public class Phase : Base
    {
        public string Nome { get; set; }
        public string Status { get; set; }
        public List<Test> Tests { get; set; }
    }
}
