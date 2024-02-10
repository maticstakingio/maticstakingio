using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.ViewModels.BotTelegram
{
    public class WithdrawMessageParam
    {
        public string Email { get; set; }
        public string SponsorEmail { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public decimal FeeAmount { get; set; }
        public string WalletFrom { get; set; }
        public string WalletTo { get; set; }
        public string LeaderShip { get; set; }

        public DateTime CreatedDate { get; set; }
        public decimal BeforeBalance { get; set; }
        public decimal AfterBalance { get; set; }
        public string Remarks { get; set; }
    }
}
