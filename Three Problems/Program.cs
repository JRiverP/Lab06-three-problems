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


System.Console.WriteLine("=== CSCI 1250 Lab 6 ===");

System.Console.WriteLine("1. The Grade Checker");
System.Console.WriteLine("2. The Dice Table");
System.Console.WriteLine("3. The Score Report");
System.Console.WriteLine("4. All three");
System.Console.WriteLine("5. Quit");
System.Console.WriteLine("Choose 1 through 5: ");
Console.Read();



System.Console.WriteLine("Goodbye");
