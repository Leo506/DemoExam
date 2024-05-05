
using DemoExam.Domain.Models;

namespace DemoExam.Blazor.Comparers;

public class StatusComparer : IComparer<string>
{
    private static readonly Dictionary<string, int> Weights = new()
    {
        [OrderStatusConstants.NewOrder] = 1,
        [OrderStatusConstants.Completed] = 2,
        [OrderStatusConstants.Cancelled] = 3
    };

    public int Compare(string? x, string? y)
    {
        if (x is null || y is null)
            return 0;
        return Weights[x].CompareTo(Weights[y]);
    }
}