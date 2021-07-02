using System;
using System.Collections.Generic; 
namespace ClassesTask{
    // Task 2.1
    class Person {
        public string Firstname;
        public string Surname;
        public string DateOfBirth;
        public int Height;
        public int ID;

        public List<string> Subjects {get; set;}
  
        public Person(string Firstname, string Surname, string DateOfBirth, int Height, int ID) {
            Random num = new Random();
            this.Firstname = Firstname;
            this.Surname = Surname;
            this.DateOfBirth = DateOfBirth;
            this.Height = Height;
            // Task 2.3
            ID = num.Next(1000,9999);
            this.Subjects = new List<string>();
        }

        public string GetFullName() {
            return Firstname + " " + Surname;
        }

        public int GetHeightDifference(int Person1, int Person2) {
            return Person1 - Person2;
        }

        public void AddSubject(string subject) {
            Subjects.Add(Console.ReadLine());
        }

        public void ViewSubjects() {
            Subjects.ForEach(Console.WriteLine);
        }
    }
}