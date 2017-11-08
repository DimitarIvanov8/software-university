Use "P02_DatabaseFirst" Entity Framework Project, 
Change the code in StartUp.cs to extract the following data from the database:

Employees and Projects
Find the first 30 employees who have projects started in the period 2001 - 2003 (inclusive). Print each employee's first name, last name, manager’s first name and last name. Then print all of their projects in the format "--<ProjectName> - <StartDate> - <EndDate>", each on a new row. If a project has no end date, print "not finished" instead.
Here is the format: 

Output:
Guy Gilbert - Manager: Jo Brown
--Half-Finger Gloves - 6/1/2002 12:00:00 AM - 6/1/2003 12:00:00 AM
--Racing Socks - 11/22/2005 12:00:00 AM - not finished
--Women's Tights - 6/1/2002 12:00:00 AM - 6/1/2003 12:00:00 AM
--Road Bottle Cage - 2/21/2004 12:00:00 AM - not finished