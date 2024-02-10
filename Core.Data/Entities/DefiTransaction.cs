﻿using Core.Data.Enums;
using Core.Infrastructure.SharedKernel;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Data.Entities
{
    [Table("DefiTransactions")]
    public class DefiTransaction : DomainEntity<Guid>
    {
        public string AddressTo { get; set; }
        public string AddressFrom { get; set; }
        public Guid AppUserId { get; set; }
        public DefiTransactionState TransactionState { get; set; } 
        public decimal USDAmount { get; set; }
        public decimal TokenAmount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string TransactionHash { get; set; }
        public bool IsDevice { get; set; }
        public string WalletType { get; set; }

        public string Remarks { get; set; }
    }
}
