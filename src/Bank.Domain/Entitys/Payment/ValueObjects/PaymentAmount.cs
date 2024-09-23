using UserManagement.Domain.Common.Models;
using System;
using System.Collections.Generic;

namespace Bank.Domain.Payment.ValueObjects
{
    public class PaymentAmount : ValueObject
    {
        public decimal Amount { get; }
        public string Currency { get; }

        public PaymentAmount(decimal amount, string currency)
        {
            if (amount < 0)
                throw new ArgumentException("Amount cannot be negative.");

            Amount = amount;
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Amount;
            yield return Currency;
        }
    }
}