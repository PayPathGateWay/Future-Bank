using System;
using System.Collections.Generic;
using UserManagement.Domain.Common.Models;

namespace Bank.Domain.Account.ValueObjects
{
    public class AccountNumber : ValueObject
    {
        public long Number { get; }

        public AccountNumber(string number)
        {
            if (string.IsNullOrWhiteSpace(number) || !long.TryParse(number, out long parsedNumber))
                throw new ArgumentException("Account number must be a valid non-empty number.", nameof(number));

            if (number.Length != 20)
                throw new ArgumentException("Account number must be exactly 20 digits.", nameof(number));

            Number = parsedNumber;
        }

        private static readonly Random random = new Random();

        public static AccountNumber GenerateRandomAccountNumber()
        {
            // Generates a 20-digit account number
            var number = random.Next(100000000, 999999999).ToString("D20");
            return new AccountNumber(number);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Number;
        }
    }
}