Employees Mapping

Create a simple database with one table – Employees. Each employee should have properties: first name, last name, salary, birthday and address. Only first name, last name and salary are required.
Create EmployeeDto class that will keep synthesized information about instances of Employee class (only id, first name, last name and salary).
Create a console app for your database, which uses the Automapper package and the EmployeeDto class to transfer data from and back to the database. You should have the following commands:
• AddEmployee <firstName> <lastName> <salary> –  adds a new Employee to the database

• SetBirthday <employeeId> <date: "dd-MM-yyyy"> – sets the birthday of the employee to the given date

• SetAddress <employeeId> <address> –  sets the address of the employee to the given string

• EmployeeInfo <employeeId> – prints on the console the information for an employee in the format "ID: {employeeId} - {firstName} {lastName} -  ${salary:f2}"

• EmployeePersonalInfo <employeeId> – prints all the information for an employee in the following format:
ID: 1 - Pesho Ivanov - $1000:00
Birthday: 15-04-1976
Address: Sofia, ul. Vitosha 15

• Exit – closes the application
Bonus
Only use DTOs in your application. Use a service to connect to the database.
