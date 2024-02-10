using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Infrastructure.Telegram.Models
{
    public class TransferMessageParam
    {
        public string Email { get; set; }
        public string UserId { get; set; }
        public string SponsorEmail { get; set; }
        public string SponsorFrom { get; set; }
        public string SponsorTo { get; set; }
        public string SponsorId { get; set; }
        public decimal AmountFrom { get; set; }
        public decimal AmountTo { get; set; }
        public string Currency { get; set; }
        public decimal FeeAmount { get; set; }
        public string WalletFrom { get; set; }
        public string WalletTo { get; set; }
        public DateTime CreatedDate { get; set; }

        public decimal BeforeBalanceFrom { get; set; }

        public decimal AfterBalanceFrom { get; set; }

        public decimal BeforeBalanceTo { get; set; }

        public decimal AfterBalanceTo { get; set; }

        public string Remarks { get; set; }
    }
}
