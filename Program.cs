using System;
using System.Collections.Generic;

namespace employees
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company.
            Company FishingInc = new Company("The Savage Fishing Company", DateTime.Now);

            // Create three employees
            Employee Liam = new Employee()
            {
                FirstName = "Bruce",
                LastName = "Liam",
                Title = "Boat Captain",
                StartDate = DateTime.Now
            };

            Employee Owen = new Employee()
            {
                FirstName = "Owen",
                LastName = "Savage",
                Title = "Croc Wrestler",
                StartDate = DateTime.Now
            };

            Employee JJ = new Employee()
            {
                FirstName = "JJ",
                LastName = "Jameson",
                Title = "Fish Wrangler",
                StartDate = DateTime.Now
            };

            // Assign the new employees by calling the add method
            // with the company they are being added to
            FishingInc.Add(Liam);
            FishingInc.Add(Owen);
            FishingInc.Add(JJ);

            // Call the method to list out the employees
            FishingInc.ListEmployees();
        }
    }
}


