numberOfCards = length of our deck

for rightIndex from numberOfCards - 1 down to 1 do:
leftIndex = random integer that is greater than or equal to 0 and LESS than rightIndex.
See the section "How do we get a random integer")

Now swap the values at rightIndex and leftIndex by doing this:
leftCard = the value from deck[leftIndex]
rightCard = the value from deck[rightIndex]
deck[rightIndex] = leftCard
deck[leftIndex] = rightCard

var randomNumberGenerator = new Random();
var randomNumber = randomNumberGenerator.Next(956);

Explorer Mode

Once the program starts, you should create a new deck.
After deck creation, you should shuffle the deck.
After the deck is shuffled, display the top two cards.

Adventure Mode

In addition to displaying the top two cards, also store these two "dealt" cards in a variable named playerHand. Consider what type of variable playerHand will have to be.
Implement a way to two deal cards each into two different hands.
