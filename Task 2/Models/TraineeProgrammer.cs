using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    public class TraineeProgrammer:ITask
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stack { get; set; }
        public TraineeProgrammer(string name, string stack)
        {
            Name = name;
            Stack = stack;
        }

        public void completeTask()
        {
            Console.WriteLine("I've completed the task");
        }

        public void sendForReview()
        {
            Console.WriteLine("I've sent the task to Tech lead and CTO for review");
        }
        public void push()
        {
            Console.WriteLine("I've pushed to prod");
        }



    }
}
