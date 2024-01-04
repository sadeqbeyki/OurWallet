﻿using Wallet.Domain.Entities.Base;
using Wallet.Domain.Enum;

namespace Wallet.Domain.Entities
{
    public class TransactionCategory : BaseEntity<int>
    {
        public string Name { get; set; }
        //public TransactionType Type { get; set; }
    }
}
