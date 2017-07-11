/*
Your task is to model an application.It is very simple. The mandatory models of our application 
are 3:  Human, Worker and Student. The parent class – Human should have first name and last name.
Every student has a faculty number.Every worker has a week salary and work hours per day.It 
should be able to calculate the money he earns by hour. You can see the constraints below.

Constraints:
Parameter:	        |   Constraint:	                        |   Exception Message:
Human first name	|   Should start with a capital letter	|   "Expected upper case letter! Argument: firstName"
Human first name	|   Should be more than 3 symbols	    |   "Expected length at least 4 symbols! Argument: firstName"
Human last name	    |   Should start with a capital letter	|   "Expected upper case letter! Argument: lastName"
Human last name	    |   Should be more than 2 symbols	    |   "Expected length at least 3 symbols! Argument: lastName "
Faculty number	    |   Should be in range [5..10] symbols	|   "Invalid faculty number!"
Week salary	        |   Should be more than 10	            |   "Expected value mismatch! Argument: weekSalary"
Working hours	    |   Should be in the range [1..12]	    |   "Expected value mismatch! Argument: workHoursPerDay"

Input:
On the first input line you will be given info about a single student - a name and faculty number. 
On the second input line you will be given info about a single worker - first name, last name, salary and working hours.

*Example input:
Stefo Mk321 0812111
Ivcho Ivancov 1590 10

*Output:
First Name: Stefo
Last Name: Mk321
Faculty number: 0812111

First Name: Ivcho
Last Name: Ivancov
Week Salary: 1590.00
Hours per day: 10.00
Salary per hour: 31.80
*/
using System;

namespace _3.Mankind
{
    class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                var studentInfo = Console.ReadLine().Split(' ');
                Student student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);

                var workerInfo = Console.ReadLine().Split(' ');
                Worker worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), decimal.Parse(workerInfo[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
