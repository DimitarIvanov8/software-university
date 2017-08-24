Card Power

Create class Card that holds Rank and Suit.  Create a program that generates a deck of cards which have a power. The power of a card 
is calculated by adding the power of its rank plus the power of its suit. Rank powers are as follows: (Ace - 14, Two - 2, Three - 3, 
Four - 4, Five - 5, Six - 6, Seven - 7, Eight - 8, Nine - 9, Ten - 10, Jack - 11, Queen - 12, King - 13). Suit powers are as follows: 
(Clubs - 0, Diamonds - 13, Hearts - 26, Spades - 39).

You will get a command consisting of two lines. On the first line you will receive the Rank of the card and on the second line you will 
get the suit of the card. 

Print the output in the format "Card name: ACE of SPADES; Card power: 53".
Note

Try using the enumeration types you have created in the previous problems but extending them with constructors and methods. To get the 
card power cast to integer Rank and Suit and add them together.

Example input:
Two
Clubs

Output:
Card name: Two of Clubs; Card power: 2

Input:
Ace
Spades

Output:
Card name: Ace of Spades; Card power: 53