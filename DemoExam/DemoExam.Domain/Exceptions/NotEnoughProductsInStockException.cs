namespace DemoExam.Domain.Exceptions;

public class NotEnoughProductsInStockException() : Exception(MessageText)
{
    public const string MessageText = "Not enough products in stock";
}