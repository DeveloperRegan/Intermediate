using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpr.OOP.UI
{
    public class Student
    {
        // fields
        private int id;
        private string firstName;
        private string lastName;


  

        public string DisplayName
        {
            get { return FirstName + " " + LastName; }
  
        }

        public DateTime DOB { get; set; }  //backing field is added behind scenes for me :)  Yippie

        public int age { get { return (DateTime.Now - DOB).Days / 365; } }
        


        //Properties
        public int Id
        {
            get { return id; }
            set {
                if(value >= 0)
                id = value;
            }
        }
    public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


    }
}
