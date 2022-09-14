using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC__.Models
{
    internal interface UserInterface
    {
        string firstName { get; set; }
        string lastName { get; set; }
        string email { get; set; }
        int age { get; set; }
        void PrintUserDetails();
    }
}
