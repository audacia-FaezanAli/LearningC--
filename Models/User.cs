using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningC__.Models
{
    public class User
    {
        public string firstName;
        public string lastName;
        public string userName;
        public DateOnly dateOfBirth;
        public string email;

        public User(string firstName, string lastName, string userName, string dateOfBirth, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.userName = userName;
            this.dateOfBirth = DateOnly.Parse(dateOfBirth);
            this.email = email;
        }

        public string LogUserDetails()
        {
            var userDetails = firstName + " " + lastName + ", " + userName + ", " + dateOfBirth + ", " + this.email;
            return userDetails;
        }
        
    }
}
