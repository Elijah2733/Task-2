using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
   
    public class TechLead
    {
        public int Id { get; set; }
        public string name { get; set; }
        //public Project project { get; set; }

        //public TechLead(string name, Project project)
        //{
        //    this.name = name;
        //    this.project = project;
        //}

        //Project? project
        public Task createtask(string name, string description )
        {
            Task task = new Task(name,description);
            return task;

        }

        public void assignTask(Intern? intern, TraineeProgrammer? programmer,Task task)
        {
            task.intern= intern;
            task.programmer= programmer;
            task.startTask();
        }

        public void reviewTask(Task task)
        {
            task.reviewed= true;
            task.endTask();
        }

        
    }
}
