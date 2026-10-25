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
int score = 0;
Random rng = new Random(4000);
string UserChoice;

// do while: the player came to roll, so that body has to run once before
// there is anything to ask about.

do
{
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



// The number of repeats is uknown prior to the loop starting,
// a user may get it right and repeat zero times, or wrong and repeat 6 times.


if(choice == 1 || choice == 4 )
{
    //Exercise 1 
System.Console.WriteLine("=== Exercise 1: The Grade Checker ===");

System.Console.Write("score: ");
score = Convert.ToInt32(Console.ReadLine());
// int score = 0;

    while(score < 0 || score > 100)
        {
            System.Console.WriteLine("A score must be between 0 and 100");
            score = Convert.ToInt32(Console.ReadLine());
        }
            if(score >= 90)
            {
                System.Console.WriteLine(score + " Earns an A");
            }
            else if(score >= 80)
            {
                System.Console.WriteLine(score + " Earns a B");
            }
            else if(score >= 70)
            {
                System.Console.WriteLine(score + " Earns a C");
            }
            else if(score >= 60)
            {
                System.Console.WriteLine(score + " Earns a D");
            }
            else if(score < 60 && score >= 0)
            {
                System.Console.WriteLine(score + " Earns a F");
            }
        
    System.Console.WriteLine(" ");

}


// the user came to roll dice, so you need to let them roll before computing whether 
// to continue or not, thus a do-while loop to execute then process in Post whether to 
// continue or not.

if(choice == 2 || choice == 4 )
{
    //Exercise 2 

int rollCount = 0;
int winCount = 0;

    System.Console.WriteLine("=== Exercise 2: The Dice Table ===");

    // int dice1 = Convert.ToInt32(rng.Next(1, 7));
    //  int dice2 = Convert.ToInt32(rng.Next(1, 7));
    // int RollTotal = dice1 + dice2;

     do
        {
        rollCount++;
        

         int dice1 = Convert.ToInt32(rng.Next(1, 7));
        int dice2 = Convert.ToInt32(rng.Next(1, 7));
        int RollTotal = dice1 + dice2;  
        

    System.Console.Write("Roll " + rollCount + ":" + dice1 + " and " + dice2 + ", total " + RollTotal);

    if(dice1 == 1 && dice2 == 1)
            {
                System.Console.WriteLine(" Snake eyes");
            }
        else if(dice1 == dice2)
            {
                System.Console.WriteLine(" Doubles!");
            }
        else if(dice1 + dice2 == 11 || dice1 + dice2 == 7)
            {
                System.Console.WriteLine(" Winner.");
                winCount++;
            }
     

    System.Console.WriteLine(" Roll again? (y/n)" );
    UserChoice = Console.ReadLine().ToUpper();

    

        }while( UserChoice == "Y");

        System.Console.WriteLine("You rolled " + rollCount + " times and won " + winCount);
        System.Console.WriteLine(" ");
}


if(choice == 3 || choice == 4 )
{
    //Exercise 3
}

}while(choice != 5);

System.Console.WriteLine("Goodbye");
