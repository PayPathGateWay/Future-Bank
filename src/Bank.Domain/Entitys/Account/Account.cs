using Bank.Domain.Account.Enum;
using Bank.Domain.Account.ValueObjects;
using Bank.Domain.Common.Model;
using System;
using Bank.Domain.DTOs;

namespace Bank.Domain.Account
{
    /// <summary>
    /// Represents an account entity in the banking domain.
    /// </summary>
    public class Account : Entity
    {
        /// <param name="accountParameters">The parameters for creating an account.</param>
        public Account(AccountParameters accountParameters)
        {
            AccountId = accountParameters.AccountId;
            CardId = accountParameters.CardId ?? throw new ArgumentNullException(nameof(accountParameters.CardId));
            UserId = accountParameters.UserId ?? throw new ArgumentNullException(nameof(accountParameters.UserId));
            AccountType = accountParameters.AccountType;
            AccountNumber = accountParameters.AccountNumber ?? throw new ArgumentNullException(nameof(accountParameters.AccountNumber));
            Balance = accountParameters.Balance;
            CreatedAt = DateTime.UtcNow;
            UpdatedAt = DateTime.UtcNow;
        }

        public Guid AccountId { get; private set; }
        public Card.Card CardId { get; private set; }
        public User.User UserId { get; private set; }
        public AccountType AccountType { get; private set; }
        public AccountNumber AccountNumber { get; private set; }
        public float Balance { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}