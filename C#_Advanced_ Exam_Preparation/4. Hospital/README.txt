Hospital

Your task will be to prepare an electronic register for a hospital. In the hospital we have different departments:
	Cardiology
	Oncology
	Emergency department 
	etc. 

Each department has 20 rooms for patients and each room has 3 beds. When a new patient goes in the hospital, he/she is placed on the first free bed in the department. If there are no free beds, the patient should go in another hospital. Of course, in every hospital there are doctors. Each doctor can have patients in a different department. You will receive information about patients in the format {Department} {Doctor} {Patient}
After the "Output" command you will receive some other commands with what kind of output you need to print. The commands are: 
	{Department}  You need to print all patients in this department in the order of receiving
	{Department} {Room}  You need to print all patients in this room in alphabetical order
	{Doctor}  you need to print all patients for this doctor in alphabetical order

The program ends when you receive command "End".
Input

On the first lines you will receive info for the hospital, department, doctors and patients in the following format:
{Department} {Doctor} {Patient}
When you read the "Output" line you will get one or more commands telling you what you need to print

Read commands for printing, till you reach the command "End"
Output
	{Department}  print all patients in this department in order of receiving on new line
	{Department} {Room}  print all patients in this room in alphabetical order each on new line
	{Doctor}  print all patients that are healed from doctor in alphabetical order on new line
Constraints
	{Department}  single word with length 1 < n < 100
	{Doctor}  name and surname, both with length 1 < n < 20
	{Patient}  unique name with length 1 < n < 20
	{Room}  integer 1 <= n <= 20
	Time limit: 0.3 sec. Memory limit: 16 MB.

Example Input:
Cardiology Petar Petrov Ventsi
Oncology Ivaylo Kenov Valio
Emergency Mariq Mircheva Simo
Cardiology Genka Shikerova Simon
Emergency Ivaylo Kenov NuPogodi
Cardiology Gosho Goshov Esmeralda
Oncology Gosho Goshov Cleopatra
Output
Cardiology
End

Output:
Ventsi
Simon
Esmeralda


Input:
Cardiology Petar Petrov Ventsi
Oncology Ivaylo Kenov Valio
Emergency Mariq Mircheva Simo
Cardiology Genka Shikerova Simon
Emergency Ivaylo Kenov NuPogodi
Cardiology Gosho Goshov Esmeralda
Oncology Gosho Goshov Cleopatra
Output
Cardiology 1
End

Output:
Esmeralda
Simon
Ventsi
