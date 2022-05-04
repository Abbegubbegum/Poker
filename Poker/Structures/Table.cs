using Poker.Objects;

namespace Poker.Structures
{
    public class Table
    {
        public List<Player> players = new();

        private Deck deck;

        private Board board;

        public Table()
        {
            deck = new Deck();

            board = new Board(deck);
        }

        public void RunGame()
        {

        }

        public void AddPlayer(Player p)
        {

        }

    }
}