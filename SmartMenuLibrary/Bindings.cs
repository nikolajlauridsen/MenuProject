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
                string noget = "";
                while (noget.Length <= 0)
                {
                    Console.Write("Please enter something: ");
                    noget = Console.ReadLine();
                    if (noget.Length <= 0){
                        Console.WriteLine("That is not something, please try again");
                    }
                }
                Console.WriteLine(Functions.DoSomething(noget));
            }
            else if (menuId == "another")
            {
                Console.WriteLine(Functions.GetTheAnswerToLifeTheUniverseAndEverything());
            }
            
        }
    }
}
