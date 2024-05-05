namespace DemoExam.Domain.Models;

public static class OrderStatusConstants
{
    public const string NewOrder = "Новый";

    public const string Completed = "Завершен";

    public const string Cancelled = "Отменен";

    public static List<string> GetAvailableStatuses() => [NewOrder, Completed, Cancelled];
}