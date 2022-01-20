namespace CardBuilder
{
	public class Card
	{
		public enum Suites
		{
			Spades,
			Clubs,
			Diamonds,
			Hearts
		}

		public int Value
		{
			get;
			set;
		}

		public Suites Suite
		{
			get;
			set;
		}

		public string NamedValue
		{
			get
			{
				switch (Value)
				{
					case (11):
						return "Jack";
					case (12):
						return "Queen";
					case (13):
						return "King";
					case (14):
						return "Ace";
				}

				return null;
			}
		}

		public string Name
		//Full name, for better readibility purposes
		//Templated as "{value} of {suite}"
		{
			get
			{
				return (NamedValue ?? Value.ToString()) + " of " + Suite.ToString();
			}
		}

		public Card(int Value, Suites Suite)
		{
			this.Value = Value;
			this.Suite = Suite;
		}
	}
}
