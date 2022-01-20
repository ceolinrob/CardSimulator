using CardBuilder;

namespace DeckBuilder
{
	public class Deck
	{
		public List<Card> Cards = new List<Card>();
		public void GenerateDeck()
		{
			for (int i = 0; i < 52; i++)
			{
				//Chooses the correct suite based on the number of cards already generated
				//The result of the calculation must be cast into (Card.Suites) form
				Card.Suites suite = ((Card.Suites)Math.Floor((decimal)i/13)); 

				//using Ace's value as high (14), face calculation should then start at 2
				int value = (i % 13) + 2;
				Cards.Add(new Card(value, suite));
			}
		}
		
		public void PrintDeck()
		{
			foreach(Card card in this.Cards)
			{
				Console.WriteLine(card.Name);
			}
			if (!this.Cards.Any()) Console.WriteLine("Deck has no more cards.");
			Console.WriteLine("\n");
		}

		public void Shuffle()
		{
			Random rnd = new Random();
			for (int i = 0; i < this.Cards.Count; i++)
			{
				Card placeholder = this.Cards[i];
				int shufflePosition = rnd.Next(this.Cards.Count);
				this.Cards[i] = this.Cards[shufflePosition];
				this.Cards[shufflePosition] = placeholder;
			}
		}

		public Card DealOneCard()
		{
			if(this.Cards.Any())
			{
				Card cardToBeReturned = this.Cards[0];
				this.Cards.RemoveAt(0);
				return cardToBeReturned;
			}
			return null;
		}

	}
}
