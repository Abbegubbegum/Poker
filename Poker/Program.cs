Deck d = new();
Board b = new(d);

Hand h1 = d.DealHand();
Hand h2 = d.DealHand();

Console.WriteLine("Hand1: " + h1);
Console.WriteLine("Hand2: " + h2);

Console.WriteLine("Board: " + b);
b.DealNextAction();

Console.WriteLine("Board: " + b);
b.DealNextAction();

Console.WriteLine("Board: " + b);
b.DealNextAction();

Console.WriteLine("Board: " + b);
b.DealNextAction();

