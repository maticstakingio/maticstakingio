using BeCoreApp.Data.Entities;
using BeCoreApp.Data.Enums;
using Core.Data.Enums;
using Core.Data.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Data.Entities
{
    [Table("AppUsers")]
    public class AppUser : IdentityUser<Guid>, IDateTracking, ISwitchable
    {
        public string Sponsor { get; set; }

        public Guid? ReferralId { get; set; }

        public string PublishKey { get; set; }

        public string PrivateKey { get; set; }

        public decimal MSCAmount { get; set; }
        public decimal MCCAmount { get; set; }
        public decimal MATICAmount { get; set; }

        public decimal StakingAmount { get; set; }
        public decimal StakingAffiliateAmount { get; set; }
        public StakingLevel StakingLevel { get; set; }

        public bool IsShowOff { get; set; }

        public bool IsRejectWithdraw { get; set; }

        public bool IsRejectInterest { get; set; }

        public bool IsRejectSwap { get; set; }

        public bool IsRejectTransfer { get; set; }

        public DateTime? LastWalletCheckingDate { get; set; }

        public int? WalletCheckingCount { get; set; }

        public bool IsAllowWalletCheck { get; set; }

        public bool IsSystem { get; set; } = false;

        public Status Status { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }

        public string ByCreated { get; set; }

        public string ByModified { get; set; }


        public virtual ICollection<Support> Supports { set; get; }
        public virtual ICollection<TicketTransaction> TicketTransactions { set; get; }
        public virtual ICollection<SystemTransaction> SystemTransactions { set; get; }
    }
}
