using System.ComponentModel.DataAnnotations;

namespace Task_2.Models
{
    public enum status_options
    {
        Inprogress,
        Complete
    }
    public class Project
    {
        public int Id { get; set; }

        [Required]
        public string ProjectName { get; set; }

        private string GitRepo { get; set; }

        public string Description { get; set; }

        public int Duration { get; private set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; private set; }

        [DataType(DataType.Date)]
        public DateTime EndDate { get; private set; }

        //public TechLead TechLead { get; set; }

        public List<Task> Tasks { get; set; } = new List<Task>();

        public string Status { get; private set; }

        //public Project(string name, string git_repo)
        //{
        //    if (string.IsNullOrWhiteSpace(name)|| string.IsNullOrWhiteSpace(git_repo))
        //    {
        //        throw new ArgumentException("Project name cannot be empty.");
        //    }

        //    ProjectName = name;
        //    GitRepo = git_repo;
        //}

        //public void setDuration(DateTime startDate, DateTime endDate)
        //{
        //    Duration = (endDate-startDate).Days;
            
        //}
        //public void startProject()
        //{
            
        //    StartDate = DateTime.Now;
        //    Status = Enum.GetName(typeof(status_options), 0);

       
        //}

        //public void endProject()
        //{

        //    EndDate = DateTime.Now;
        //    Status = Enum.GetName(typeof(status_options), 1);
        //    setDuration(StartDate, EndDate);

        //}
        //public bool isProjectComplete()
        //{
        //    return Tasks.All(task => task.status == "Complete");
        //}

        //public void assignTechLead(TechLead tecLead)
        //{
        //    TechLead = tecLead;
        //}


    }
}
    

