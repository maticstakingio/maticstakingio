using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.ViewModels.BlockChain
{
    public class WalletViewModel
    {
        public string PublishKey { get; set; }
        public decimal MSCAmount { get; set; }
        public decimal MCCAmount { get; set; }
        public decimal MATICAmount { get; set; }
    }
}
