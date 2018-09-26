using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionLibrary;

namespace SmartMenuLibrary {
    class Bindings {
        public static void Call(String menuId) {
            // Implement call here 
            // Hint - lav switch case some caller metoderne i functions.cs og printer resultatet. 
            if (menuId == "this")
            {
                Console.WriteLine(Functions.DoThis());
            }
            else if (menuId == "that")
            {
                Console.WriteLine(Functions.DoThat());

            }
            else if (menuId == "something")
            {
                Console.Write("Please enter something: ");
                string noget = Console.ReadLine();
                Console.WriteLine(Functions.DoSomething(noget));
            }
            else if (menuId == "another")
            {
                Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
            }
        }
    }
}
