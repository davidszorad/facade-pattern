using System;
using System.Collections.Generic;
using System.Text;

namespace FacadePattern.Structural
{
    /*
    This structural code demonstrates the Facade pattern which provides a simplified 
    and uniform interface to a large subsystem of classes.

    OUTPUT:
    MethodA() ----
    SubSystemOne Method
    SubSystemTwo Method
    SubSystemFour Method

    MethodB() ----
    SubSystemTwo Method
    SubSystemThree Method
    */

    /// <summary>
    /// MainApp startup class for Structural
    /// Facade Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        public static void MainStructural()
        {
            Facade facade = new Facade();

            facade.MethodA();
            facade.MethodB();

            // Wait for user
            Console.ReadKey();
        }
    }
}
