using Bank.Domain.Common.Model;
using Bank.Domain.Payment.Enum;
using System;
using Bank.Domain.DTOs;
using Bank.Domain.Payment.ValueObjects;

namespace Bank.Domain.Payment
{
    /// <summary>
    /// Represents a payment entity in the banking domain.
    /// </summary>
    public class Payments : Entity
    {
        /// <param name="paymentParameters">The parameters for creating a payment.</param>
        public Payments(PaymentParameters paymentParameters)
        {
            PaymentId = Guid.NewGuid();
            TransactionId = paymentParameters.TransactionId; 
            Amount = paymentParameters.Amount;
            PaymentDueDate = paymentParameters.PaymentDueDate;
            PaymentMethod = paymentParameters.PaymentMethod;
            PaymentStatus = paymentParameters.PaymentStatus;
        }

        public Guid PaymentId { get; private set; }
        public Transaction.Transaction TransactionId { get; private set; }
        public PaymentAmount Amount { get; private set; }
        public PaymentMethod PaymentMethod { get; private set; }
        public PaymentStatus PaymentStatus { get; private set; }
        public DateTime PaymentDueDate { get; private set; }
    }
}