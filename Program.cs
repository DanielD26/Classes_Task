using System;

namespace ClassesTask
{
    class Program {
        static void Main(string[] args) {
            // Task 1.2
            // Cookie ChocChip = new Cookie();

            // Task 1.5
            Cookie ChocChip = new Cookie(10, "circle", "Light Brown");
            Cookie Chocolate = new Cookie(15, "Star", "Dark Brown");

            
            // Task 2.2
            Person Daniel = new Person("Daniel", "Diaz", "26/02/2002", 178, 1);
            Person Chris = new Person("Chris", "Paul", "06/05/1985", 183, 2);
            Person Stephen = new Person("Stephen", "Curry", "14/03/1988", 191, 3);

            Console.WriteLine(Daniel.GetFullName());
            Console.WriteLine(Chris.GetFullName());
            Console.WriteLine(Stephen.GetFullName());

            Console.WriteLine(Daniel.ID);
            Console.WriteLine(Chris.ID);
            Console.WriteLine(Stephen.ID);

            Console.WriteLine(Daniel.GetHeightDifference(Chris.Height, Daniel.Height));
            Console.WriteLine(Chris.GetHeightDifference(Stephen.Height, Chris.Height));
            Console.WriteLine(Stephen.GetHeightDifference(Stephen.Height, Daniel.Height));

            Console.WriteLine(Daniel.AddSubject("Maths"));
        }

    }
}
