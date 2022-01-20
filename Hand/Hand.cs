using CardBuilder;

namespace HandBuilder
{
    public class Hand
    {
        public List<Card> Cards = new List<Card>();

        public void PrintHand()
		{
			foreach(Card card in this.Cards)
			{
				Console.WriteLine(card.Name);
			}
			if (!this.Cards.Any()) Console.WriteLine("Hand is currently empty.");
			Console.WriteLine("\n");
		}
    }
}