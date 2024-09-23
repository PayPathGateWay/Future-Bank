using System;
using System.Collections.Generic;
using UserManagement.Domain.Common.Models;

namespace Bank.Domain.Card.ValueObjects
{
    /// <summary>
    /// Represents the card network type (e.g., Visa, MasterCard).
    /// </summary>
    public class CardNetwork : ValueObject
    {
        public string Name { get; private set; }
        public DateTime ExpirationDate { get; private set; }
        public DateTime IssuerDate { get; private set; }

        public CardNetwork(string name, DateTime expirationDate, DateTime issuerDate)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ExpirationDate = expirationDate;
            IssuerDate = issuerDate;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Name;
            yield return ExpirationDate;
            yield return IssuerDate;
        }

        /// <summary>
        /// Generates a random card number based on the card network type.
        /// </summary>
        public static string GenerateCardNumber(CardNetwork network)
        {
            return network.Name switch
            {
                "Visa" => GenerateVisaCardNumber(),
                "MasterCard" => GenerateMasterCardNumber(),
                "PathNet" => GeneratePathNetCardNumber(),
                _ => throw new NotSupportedException("Card network not supported.")
            };
        }

        /// <summary>
        /// Generates a random CVV number.
        /// </summary>
        public static string GenerateCVV()
        {
            return new Random().Next(100, 1000).ToString(); // 3-digit CVV
        }

        private static string GenerateVisaCardNumber()
        {
            var random = new Random();
            return "4" + random.Next(10000000, 99999999).ToString() + random.Next(10000000, 99999999).ToString(); // Generate 16 digits
        }

        private static string GenerateMasterCardNumber()
        {
            var random = new Random();
            return "4" + random.Next(10000000, 99999999).ToString() + random.Next(10000000, 99999999).ToString(); // Generate 16 digits
        }

        private static string GeneratePathNetCardNumber()
        {
            // Implement PathNet card number generation logic here
            throw new NotImplementedException("PathNet card number generation not implemented.");
        }
    }
}
