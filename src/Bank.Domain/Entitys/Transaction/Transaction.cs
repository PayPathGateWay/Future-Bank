using System.Transactions;
using Bank.Domain.Common.Model;
using Bank.Domain.Transaction.Enum;
using Bank.Domain.Transaction.ValueObjects;

namespace Bank.Domain.Transaction;

public class Transaction:Entity
{
    
    public Guid TransactionId { get; private set; }
    public Account.Account AccountId { get; private set; }
    public TransactionType Type { get; private set; }
    public TotalAmount TotalAmount { get; private set; }
    public DateTime TransactionDueDate { get; private set; }
    public DateTime TransactionUpdate { get; private set; }
    public TransactionStatus Status { get; private set; }
    
}