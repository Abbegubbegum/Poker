using Poker.enums;

namespace Poker.Objects
{
    public struct Card
    {
        public Suit Suit { get; init; }
        public CardValue Value { get; init; }

        public Card(Suit suit, CardValue value)
        {
            Suit = suit;
            Value = value;
        }

        public override string? ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}