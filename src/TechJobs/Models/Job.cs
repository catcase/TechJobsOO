namespace TechJobs.Models
{
    public class Job
    {
        public int ID { get; set; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer Employer { get; set; }
        public Location Location { get; set; }
        public CoreCompetency CoreCompetency { get; set; }
        public Skill PositionType { get; set; }

        public Job()
        {
            ID = nextId;
            nextId++;
        }

    }
}
