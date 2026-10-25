/*
*Name:          Jonathan River Phillips
*Course:        CSCI 1250, Section 002
*Assignment:    Lab06, Three short Problems
*Date:          October 21,2026
*Description:   A menu that keeps running until the user quits, offering three
*               independent exercises or all three at once. Each exercise
*               practices decisions and one of the four loops.
*/

using System.Xml.Serialization;

int choice = 0;

Random rng = new Random(4000);

// do while: the player came to roll, so that body has to run once before
// there is anything to ask about.

// do
// {
System.Console.WriteLine("=== CSCI 1250 Lab 6 ===");

System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");
  System.Console.WriteLine("Choose 1 through 5: ");
  choice = Convert.ToInt32(Console.ReadLine());

  while(choice < 1 || choice > 5 )
{
    System.Console.WriteLine("choose a number from 1 to 5: ");
    System.Console.WriteLine("Choose 1 through 5: ");
     choice = Convert.ToInt32(Console.ReadLine());
  
}


// if(choice == 1 || choice == 4 )
// {
//     //Exercise 1 
// System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");

// int score = Convert.ToInt32(Console.ReadLine()) ; 

//     while(score >= 90 && score < 101)
//         {
//             System.Console.WriteLine(score + " earns an A");
//         }

//     while(score >= 80 && score <= 89)
//     {
//         System.Console.WriteLine(score + "earns a B");
//     }

//     while(score >= 70 && score <= 79)
//     {
//       System.Console.WriteLine(score + "earns a C");
//     }

//     while(score >= 60 && score <= 69)
//     {
//       System.Console.WriteLine(score + "earns a D");
//     }

//     while(score < 60)
//     {
//       System.Console.WriteLine(score + "earns a F");
//     }
// }


// if(choice == 2 || choice == 4 )
// {
//     //Exercise 2 
// }


// if(choice == 3 || choice == 4 )
// {
//     //Exercise 3
// }

// }while(choice != 5);

System.Console.WriteLine("Goodbye");
