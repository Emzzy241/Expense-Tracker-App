// The user-Interface C# file

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // Making use of a Dictionary that will be helping me store a string(the name of my user's expense) as a key
        // And the Amount in integer(which is the amount if cash user spent on that expense)
        // Creating the Dictionary from the onset so we have a perfect global system in our App

        // Immediately use gives me their amount charged and what that particular expense is about, we add them to our Dictionary with the .Add() method we use for Lists and Dictionaries.
        // NOTE: the .Add() method won't work on C# Arrays; Nothing can be added or removed from a C# array when created

        Dictionary<string, int> expenseDictionary = new Dictionary<string, int>() { };

        // Clearing out our Dictionary everytime we start from scratch again
        // expenseDictionary.Clear();


        Console.WriteLine("Welcome to the Dynasty's Expense Tracker App");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("The major goal of our App is cutting down your expenses to the minimum");

        Console.WriteLine();

        Console.WriteLine("Press ['Y' to continue and 'N' to exit Application]");

        string userContinue1 = Console.ReadLine().ToUpper();


        if (userContinue1 == "Y")
        {
            Console.WriteLine("Tell us about the first expenses");
            Console.WriteLine();
            string expense1 = Console.ReadLine();
            // Console.WriteLine("Press Enter to continue.......");

            Console.WriteLine("Enter the Amount of money you spent on that Expenses");
            Console.WriteLine();
            string expense1Amount = Console.ReadLine();
            int expense1AmountInt = int.Parse(expense1Amount);


            // Adding the first expense to the dictionary
            expenseDictionary.Add(expense1, expense1AmountInt);

            Console.WriteLine("If you would like to input another expense, Enter 'Y' To exit App; Enter 'N', and to see how many Expenses you have now, Enter 'S'");

            string userContinue2 = Console.ReadLine().ToUpper();

            if (userContinue2 == "Y")
            {
                Console.WriteLine("What was your second Expense");
                string expense2 = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("How much did you spend on that?");
                string expense2Amount = Console.ReadLine();
                int expense2AmountInt = int.Parse(expense2Amount);

                expenseDictionary.Add(expense2, expense2AmountInt);

                // For the 3rd expenses
                Console.WriteLine("If you would like to input another expense, Enter 'Y' To exit App; Enter 'N', and to see how many Expenses you have now, Enter 'S'");

                string userContinue3 = Console.ReadLine().ToUpper();
                if (userContinue3 == "Y")
                {
                    Console.WriteLine("What was your third Expense");
                    string expense3 = Console.ReadLine();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("How much did you spend on that?");
                    string expense3Amount = Console.ReadLine();
                    int expense3AmountInt = int.Parse(expense3Amount);

                    expenseDictionary.Add(expense3, expense3AmountInt);

                    // For the 4th expenses
                    Console.WriteLine("If you would like to input another expense, Enter 'Y' To exit App; Enter 'N', and to see how many Expenses you have now, Enter 'S'");

                    string userContinue4 = Console.ReadLine().ToUpper();
                    if (userContinue4 == "Y")
                    {
                        Console.WriteLine("What was your fourth Expense");
                        string expense4 = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("How much did you spend on that?");
                        string expense4Amount = Console.ReadLine();
                        int expense4AmountInt = int.Parse(expense4Amount);

                        expenseDictionary.Add(expense4, expense4AmountInt);

                        // For the 5th expenses
                        Console.WriteLine("If you would like to input another expense, Enter 'Y' To exit App; Enter 'N', and to see how many Expenses you have now, Enter 'S'");

                        string userContinue5 = Console.ReadLine().ToUpper();
                        if (userContinue4 == "Y")
                        {
                            Console.WriteLine("What was your fourth Expense");
                            string expense5 = Console.ReadLine();
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("How much did you spend on that?");
                            string expense5Amount = Console.ReadLine();
                            int expense5AmountInt = int.Parse(expense5Amount);

                            expenseDictionary.Add(expense5, expense5AmountInt);

                            // Displaying to my User all of the Expenses they have

                            Console.WriteLine("Here are all the Expenses you have");
                            Console.WriteLine("On the expenses '" + expense1 + "' You spent: " + expenseDictionary[expense1]);
                            Console.WriteLine("On the expenses '" + expense2 + "' You spent: " + expenseDictionary[expense2]);
                            Console.WriteLine("On the expenses '" + expense3 + "' You spent: " + expenseDictionary[expense3]);
                            Console.WriteLine("On the expenses '" + expense4 + "' You spent: " + expenseDictionary[expense4]);
                            Console.WriteLine("On the expenses '" + expense5 + "' You spent: " + expenseDictionary[expense5]);


                        }

                        // else if (userContinue5 == "S")
                        // {
                        //     Console.WriteLine("Here are all the Expenses you have");

                        //     Console.WriteLine("On the expensess '" + expense2 + "' You spent: " + expenseDictionary[expense2]);
                        //     Console.WriteLine("On the expensess '" + expense2 + "' You spent: " + expenseDictionary[expense2]);
                        //     Console.WriteLine("On the expensess'" + expense3 + "' You spent: " + expenseDictionary[expense3]);
                        //     Console.WriteLine("On the expensess '" + expense4 + "' You spent: " + expenseDictionary[expense4]);
                        // }


                        // else
                        // {
                        //     Console.WriteLine("Goodbye My Dear User");
                        // }


                    }
                    else if (userContinue4 == "S")
                    {
                        Console.WriteLine("Here are all the Expenses you have");

                        Console.WriteLine("On the expenses '" + expense1 + "' You spent: " + expenseDictionary[expense1]);
                        Console.WriteLine("On the expenses '" + expense2 + "' You spent: " + expenseDictionary[expense2]);
                        Console.WriteLine("On the expenses '" + expense3 + "' You spent: " + expenseDictionary[expense3]);
                    }


                    else
                    {
                        Console.WriteLine("Goodbye My Dear User");
                    }

                }
                else if (userContinue3 == "S")
                {
                    Console.WriteLine("Here are all the Expenses you have");
                    Console.WriteLine("On the expenses '" + expense1 + "' You spent: " + expenseDictionary[expense1]);
                    Console.WriteLine("On the expenses '" + expense2 + "' You spent: " + expenseDictionary[expense2]);
                }



                else
                {
                    Console.WriteLine("Goodbye My Dear User");
                }
            }



            else if (userContinue2 == "S")
            {
                Console.WriteLine("Here are all the Expenses you have");
                Console.WriteLine("On the expenses '" + expense1 + "' You spent: " + expenseDictionary[expense1]);
            }

            else
            {
                Console.WriteLine("Goodbye My Dear User");
            }



        }

        else
        {
            Console.WriteLine("Goodbye My Dear User");
        }


    }
}

