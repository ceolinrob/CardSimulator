using DeckBuilder;
using HandBuilder;
using CardBuilder;

namespace GameBuilder
{
    public class Game
    {
        public void RunGame() 
        {
            Deck deck = new Deck();
            Hand hand = new Hand();
            deck.GenerateDeck();

            int stopRunning = 0;
            while (stopRunning == 0)
            {
                int choice = 0;
                Console.WriteLine("-----------------------------");
                Console.WriteLine("What shall be the next move?");
                Console.WriteLine("1. Shuffle deck.");
                Console.WriteLine("2. Deal one card.");
                Console.WriteLine("3. Display deck.");
                Console.WriteLine("4. Display hand.");
                Console.WriteLine("9. Exit program.");
                Console.WriteLine("-----------------------------");
                string input = Console.ReadLine();
                Int32.TryParse(input, out choice);

                switch (choice)
                {
                    case (1):
                        deck.Shuffle();
                        Console.Clear();
                        break;

                    case (2):
                        Console.Clear();
                        Card card = deck.DealOneCard();
                        if (card == null)
                        {
                            Console.WriteLine("No more cards to deal.\n");
                            break;
                        }
                        hand.Cards.Add(card);
                        Console.WriteLine("Dealt one card to the hand.\n");
                        break;

                    case (3):
                        Console.Clear();
                        Console.WriteLine("Displaying current deck.\n");
                        deck.PrintDeck();
                        break;

                    case (4):
                        Console.Clear();
                        Console.WriteLine("Displaying current hand.\n");
                        hand.PrintHand();
                        break;

                    case (9):
                        stopRunning = 1;
                        break;

                    default:
                        Console.WriteLine("{0} is not an option. Please pick a valid option.", choice);
                        break;
                }
            }
        }
    }
}