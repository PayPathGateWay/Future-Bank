using UserManagement.Domain.Common.Models;

namespace Bank.Domain.Transaction.ValueObjects;

public class TotalAmount : ValueObject
{
    public decimal Amount { get; }
    public string Currency { get; }

    public TotalAmount(decimal amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return Amount;
        yield return Currency;
    }
}
