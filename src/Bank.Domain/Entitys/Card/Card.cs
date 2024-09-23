using Bank.Domain.Card.Enum;
using Bank.Domain.Card.ValueObjects;
using System;
using Bank.Domain.DTOs;

namespace Bank.Domain.Card
{
    /// <summary>
    /// Represents a card entity in the banking domain.
    /// </summary>
    public class Card
    {
        /// <param name="cardParameters">The parameters for creating a card.</param>
        public Card(CardParameters cardParameters)
        {
            CardId = Guid.NewGuid();
            CardType = cardParameters.CardType;
            CardNetwork = cardParameters.CardNetwork;
            CardNameHolder = cardParameters.CardNameHolder ?? throw new ArgumentNullException(nameof(cardParameters.CardNameHolder));
            CardIssuer = cardParameters.CardIssuer ?? throw new ArgumentNullException(nameof(cardParameters.CardIssuer));
        }

        public Guid CardId { get; private set; }
        public CardType CardType { get; private set; } // debt or credit
        public CardNetwork CardNetwork { get; private set; } // visa, MasterCard or PathNet this will generate the card number and cvv
        public string CardNameHolder { get; private set; }
        public string CardIssuer { get; private set; } // always Future-Bank
    }
}