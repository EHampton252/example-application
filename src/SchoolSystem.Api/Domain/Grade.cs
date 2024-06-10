namespace SchoolSystem.Api.Domain
{
    public class Grade
    {
        public Grade()
        {
        }

        public int Id { get; set; }
        public string GradeName { get; set; }
        private List<Student> Students { get; set; } = new List<Student>();
        public readonly List<Student> Students { get; set; }
    }
}
