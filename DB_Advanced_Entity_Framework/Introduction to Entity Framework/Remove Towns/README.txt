Use "P02_DatabaseFirst" Entity Framework Project, 
Change the code in StartUp.cs to extract the following data from the database:

Remove Towns
Write a program that deletes a town by its name, given as an input. Also, delete all addresses that are in those towns. Print on the console the number of addresses that were deleted. There will be employees living at those addresses, which will be a problem when trying to delete the addresses. So, start by setting the AddressID of each employee for the given address to null. After all of them are set to null, you may safely remove all the addresses from the context.Addresses and finally remove the given town. You should test this task locally, so you can see what happens for more than 1 case of deletion.

Input:
Sofia
Seattle

Output:
1 address in Sofia was deleted
44 addresses in Seattle were deleted
