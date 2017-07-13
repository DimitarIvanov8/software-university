Your task is to create a class hierarchy like in the picture below. All the classes except Vegetable, Meat, Mouse, Tiger, Cat & Zebra should be abstract. Override method ToString(). 

Input should be read from the console. Every odd line will contain information about the Animal in following format:
{AnimalType} {AnimalName} {AnimalWeight} {AnimalLivingRegion} [{CatBreed} = Only if its cat]
On the even lines you will receive information about the food that you should give to the Animal. The line will consist of FoodType and quantity separated by a whitespace.
{FoodType} {Quantiy} 
You should build the logic to determine if the animal is going to eat the provided food. The Mouse and Zebra should check if the food is a Vegetable. If it is they will eat it - otherwise you should print a message in the format:
{AnimalType in plural} are not eating that type of food!

Cats eat any kind of food, but Tigers accept only Meat. If Vegetable is provided to a Tiger message like the one above should be printed on the console.

Override ToString() method to print the information about the animal in format:

{AnimalType}[{AnimalName}, {CatBreed}, {AnimalWeight}, {AnimalLivingRegion}, {FoodEaten}]
After you read information about the Animal and Food then invoke the MakeSound() method of the current animal and then feed it. At the end print the whole object and proceed reading information about the next animal/food. The input will continue until you receive “End” for animal information.
Sounds produced by the animals:
•	Mouse – “SQUEEEAAAK!”
•	Zebra – “Zs”
•	Cat – “Meowwww”
•	Tiger – “ROAAR!!!”
Input
You will receive lines on the Console until the command “End” is received. On every odd line you will be provided with information about an animal. On every even line you will receive the food which is given to the animal.
Output
For each animal you have read, print two lines on the Console:
•	On the first line: the sound produced by the animal
•	On the second line: all the information about the animal in the format described above

Exmaple input:
Cat Gray 1.1 Home Persian
Vegetable 4
End

outoput:
Meowwww
Cat[Gray, Persian, 1.1, Home, 4]
