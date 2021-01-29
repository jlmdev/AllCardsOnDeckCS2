# AllCardsOnDeckCS2

Create a deck of 52 cards
All cards should be represented as strings
Create 4 suits (Spades, Clubs, Hearts and Diamonds)
Create 13 ranks (A,2,3,4,5,6,7,8,9,10,J,Q,K)
Shuffle the cards using Fisher-Yates shuffle

make n = number of cards in our deck

# Fisher-Yates shuffle algorithm

for rightIndex from n - 1 down to 1 do:
leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex

Now swap the values at rightIndex and leftIndex by doing this:
leftCard = the value from deck[rightIndex]
rightChard = the value from deck[leftIndex]
deck[rightIndex] = rightChard
deck[leftIndex] = leftCard

# Explorer Mode

- Once the program starts, you should create a new deck
- After deck creation, you should shuffle the deck
- After the deck is shuffled, display the top two cards

# Adventure Mode

- In addition to displaying the top two cards, also store these 2 dealt cards in a variable named playerHand. Consider what type of variable playerHand will have to be.
- Implement a way to deal cards into the two different hands

# Epic Mode

- Implement the game of war
