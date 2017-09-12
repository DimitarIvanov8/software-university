Cubic’s Rube

Several years ago, while Cubic was researching a new quantum technology, to design a weapon he can use against the Spherical Race, he discovered a magical sub-dimension which stands in the cross-road of all other dimensions. The dimension was completely empty but it had a perfect cubic form and Cubic liked that a lot, so he named it after himself – The Cubic’s Rube.
Cubic noticed that the Rube gets frequently bombarded with particles which fill it, so he decided to research its volume to see how it reacts with particles. He asked for help from The Great Cubical Army, and, guess what? They sent you.
You will be given n – an integer specifying the 3 dimensions of The Rube. Only 1 integer is used for all 3 dimensions because The Rube is a perfect cube. After that you will start receiving lines containing 4 integers separated by a single space. The first three integers will represent a point in the 3D space, and the last integer will represent the particles. You must bombard that cell at that point, if there is such cell, with the given particles, adding to it – the value corresponding to the given 4th integer. Note that the properties specified above apply only for cells INSIDE The Rube. Also, there will be NO cell that is hit more than 1 times by particles.
The input ends when you receive the command “Analyze”. Then you must print the sum of all the cells in The Rube, along with the number of cells which’s value has not been changed. See the output section for more info.
Input
•	The first line of input will hold an integer n.
•	After that you will begin receiving lines of input containing 4 integers separated by a space.
•	The input ends when you receive the command “Analyze”.

Output
•	The output consists of two lines.
•	On the first line print the sum of all the cells in the Rube.
•	On the second line print the amount of cells which’s value has not been changed.

Constraints
•	The dimensions of the matrix – n will be in the range [0, 25].
•	The integers from the input lines will be in the range [-231 + 1, 231 – 1].
•	Allowed time/memory: 100ms/16MB.

Example Input:
4
2 2 2 2
Analyze

Output:
2
63


Input:
5
3 2 3 10
-1 -1 -1 0
1 4 0 20
2 2 2 5
Analyze

Output:
35
122