namespace Data.Models
{
    public class Criteria : Base
    {
        public string Description { get; set; }
        public Skill Skill { get; set; }
        public string MinimalGrade { get; set; }
    }
}
