using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Test : Base
    {
        public int AmountOfQuestions { get; set; }
        public DateTime Date { get; set; }
        public float Time { get; set; }
        public byte Result { get; set; }
        public Criteria Criteria { get; set; }
        public List<Criteria> ListCriteria { get; set; }
        public List<Skill> ListSkill { get; set; }
        public List<Phase> ListPhase { get; set; }
    }
}
