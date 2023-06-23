using PickRandomCards;

Console.Write("Enter how many cards you would like to be randomly chosen: ");

string input = Console.ReadLine();

if (int.TryParse(input, out int value))
{
    string[] cards = CardPicker.PickSomeCards(value);
    string message = "Your chosen cards are:";
    foreach(string card in cards) message += $" {card},";
    message = message.Substring(0, message.Length - 1) + '.';
    Console.WriteLine(message);
}
else
{
    Console.Write("The input is not a valid number! Please try again: ");
}