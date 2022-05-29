namespace PokerProject
{
    class Category
    {
        public enum Figure
        {
            Ace,
            King,
            Queen,
            Jack,
            Ten,
            Nine,
            Eight,
            Seven,
            Six,
            Five,
            Four,
            Three,
            Two,
        }
        public enum Suit
        {
            Spades,
            Clubs,
            Diamonds,
            Hearts,
        }
        public enum HandType
        {
            RoyalFlush,
            StraightFlush,
            FourOfAKind,
            FullHouse,
            Flush,
            Straight,
            ThreeOfAKind,
            TwoPairs,
            Pair,
            HighCard,
        }

    }
}
