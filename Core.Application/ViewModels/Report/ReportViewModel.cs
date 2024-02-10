using Core.Application.ViewModels.System;
using Core.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.Application.ViewModels.Report
{
    public class ReportViewModel
    {
        public ReportViewModel()
        {
        }

        public int TotalMember { get; set; }
        public int TodayMember { get; set; }
        public int TotalMemberVerifyEmail { get; set; }
        public int TotalMemberInVerifyEmail { get; set; }

        public decimal StakingAmount { get; set; }
        public decimal StakingBufferAmount { get; set; }
        public decimal StakingAmountUSDT { get; set; }
        public decimal StakingAffiliateAmount { get; set; }
        public decimal StakingProfitAmount { get; set; }
        public decimal StakingMaxout { get; set; }
    }
}
