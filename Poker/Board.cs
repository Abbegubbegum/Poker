
public class Board
{
    public Card?[] cards = new Card?[5];

    private Deck d;

    public Board(Deck d)
    {
        this.d = d;
    }

    public void DealNextAction()
    {
        if (cards[0] == null)
        {
            DealFlop();
        }
        else if (cards[3] == null)
        {
            DealTurn();
        }
        else if (cards[4] == null)
        {
            DealRiver();
        }
        else
        {
            Console.WriteLine("Board Finished");
        }
    }

    private void DealFlop()
    {
        cards[0] = d.DealCard();
        cards[1] = d.DealCard();
        cards[2] = d.DealCard();
    }

    private void DealTurn()
    {
        cards[3] = d.DealCard();
    }

    private void DealRiver()
    {
        cards[4] = d.DealCard();
    }

    public override string? ToString()
    {
        return $"{cards[0]} - {cards[1]} - {cards[2]} - {cards[3]} - {cards[4]}";
    }
}
