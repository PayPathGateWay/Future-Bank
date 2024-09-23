using Bank.Domain.Payment.Enum;
using Bank.Domain.Payment.ValueObjects;

namespace Bank.Domain.DTOs;

/// <summary>
/// Parameters required to create a Payment.
/// </summary>
public record PaymentParameters(
    Transaction.Transaction TransactionId, 
    PaymentAmount Amount, 
    DateTime PaymentDueDate, 
    PaymentMethod PaymentMethod, 
    PaymentStatus PaymentStatus
);