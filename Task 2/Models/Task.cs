using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    
    public class Task
    {
        public int Id { get; set; }
        public string name { get; set; }

        public string description { get; set; }

        Project project { get; set; }

        public string status { get; set; }

        public TraineeProgrammer programmer { get; set; }

        public Intern intern { get; set; }

        public bool reviewed { get; set; }

        public DateTime startDate { get; private set; }

        public DateTime endDate { get; private set; }

        public int duration { get; private set; }


        public Task(string name, string description)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Task name and description cannot be empty.");
            }

            this.name = name;
            this.description = description;
            //this.project = project;
            startTask();
        }

        public void startTask()
        {
            this.startDate= DateTime.Now;
            this.status = Enum.GetName(typeof(status_options), 0);
        }

        public void endTask()
        {
            this.endDate= DateTime.Now;
            this.status = Enum.GetName(typeof(status_options), 1);
        }

        public void setDuration(DateTime start, DateTime end)
        {
            this.duration = end.Month - start.Month;
        }

    }
}
