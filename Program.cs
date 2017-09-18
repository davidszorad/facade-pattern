using System;

namespace FacadePattern
{
    /// <summary>
    /// Program startup class for Real-World 
    /// Facade Design Pattern.
    /// </summary>
    class Program
    {
        /*
        This real-world code demonstrates the Facade pattern as a MortgageApplication object 
        which provides a simplified interface to a large subsystem of classes measuring 
        the creditworthyness of an applicant.


        The classes and objects participating in this pattern are:

        Facade   (MortgageApplication)
            knows which subsystem classes are responsible for a request.
            delegates client requests to appropriate subsystem objects.

        Subsystem classes   (Bank, Credit, Loan)
            implement subsystem functionality.
            handle work assigned by the Facade object.


        OUTPUT:
        Ann McKinsey applies for $125,000.00 loan

        Check bank for Ann McKinsey
        Check loans for Ann McKinsey
        Check credit for Ann McKinsey

        Ann McKinsey has been Approved
        */

        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main(string[] args)
        {
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user
            Console.ReadKey();
        }
    }
}