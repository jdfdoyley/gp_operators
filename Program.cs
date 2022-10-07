/************************************************************
 * Name: Jason D'Oyley
 * Date: Oct. 6, 2022
 * Assignment CIS214 Week 1 GP - Operations and Data Types
 *
 * Main application (program) class.
 * In this application we will devlare variables of various types, compare
 * variables using comparison operators, get numberic values from the user
 * via the console, add the numbers received, and print the results of
 * each operation performed.
 */
public class OperatorsDataTypes
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("\nJason D'Oyley - Week 1 GP Operators & Data Types\n");

        // Declare 3 integer values
        int intVal1 = 0;
        int intVal2 = 5;
        int intVal3 = 5;

        // Demonstrate comparison operators
        // Equality
        if (intVal2 == intVal3)
        {
            Console.WriteLine("{0:D} is equal to {1:D}", intVal2, intVal3);
        }

        // Inequality
        if (intVal1 != intVal3)
        {
            Console.WriteLine("{0:D} is not equal to {1:D}", intVal1, intVal3);
        }

        // Less Than
        if (intVal1 < intVal3)
        {
            Console.WriteLine("{0:D} is less than {1:D}", intVal1, intVal3);
        }
    }
}