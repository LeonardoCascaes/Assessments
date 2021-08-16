namespace Data.Models
{
    public class Assessment : Base
    {
        public Criteria Criteria { get; set; }
        public string AssessedGrade { get; set; }
        public string Comment { get; set; }
    }
}
