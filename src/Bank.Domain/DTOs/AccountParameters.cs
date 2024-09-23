using Bank.Domain.Account.Enum;
using Bank.Domain.Account.ValueObjects;

namespace Bank.Domain.DTOs;


/// <summary>
/// Parameters required to create an Account.
/// </summary>
public record AccountParameters(
    Guid AccountId, 
    Card.Card CardId, 
    User.User UserId, 
    AccountType AccountType, 
    AccountNumber AccountNumber, 
    float Balance
);