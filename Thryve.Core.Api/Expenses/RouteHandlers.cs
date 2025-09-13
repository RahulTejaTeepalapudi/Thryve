using Thryve.Core.Api.Expenses.Contract;

namespace Thryve.Core.Api.Expenses
{
    public static class RouteHandlers
    {
        public static RouteGroupBuilder MapRoutes(this RouteGroupBuilder group)
        {
            group.MapGet("expenses", GetExpenses);
            return group;
        }

        public static async Task<IResult> GetExpenses()
        {
            await Task.Delay(100); // Simulate async work
            var result = new ExpenseResult
            {
                Id = 1,
                Description = "Sample Expense",
                Amount = 99.99m,
                Date = DateTime.UtcNow
            };
            return Results.Ok(result);
        }
    }
}
