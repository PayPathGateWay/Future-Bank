using Bank.Domain.Card.Enum;
using Bank.Domain.Card.ValueObjects;

namespace Bank.Domain.DTOs;


/// <summary>
/// Parameters required to create a Card.
/// </summary>
public record CardParameters(
    CardType CardType, 
    CardNetwork CardNetwork, 
    string CardNameHolder, 
    string CardIssuer
);