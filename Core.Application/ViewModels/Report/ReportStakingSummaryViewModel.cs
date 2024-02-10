using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Application.ViewModels.Report
{
    public class ReportStakingSummaryViewModel
    {
        public decimal StakingAmount {get;set;}

        public decimal StakingAffiliateAmount { get;set;}

        public decimal StakingMaxout { get; set; }

        public int ReferralLevel { get;set;}


        public decimal StakingProfit { get; set; }
        public decimal StakingAffiliateOnProfit { get; set; }
        public decimal StakingReferralDirect { get; set; }
        public decimal StakingLeadership { get; set; }
    }
}
