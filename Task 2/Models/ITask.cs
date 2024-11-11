using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2.Models
{
    interface ITask
    {
        public void completeTask();

        public void sendForReview();

        public void push();


    }
}
