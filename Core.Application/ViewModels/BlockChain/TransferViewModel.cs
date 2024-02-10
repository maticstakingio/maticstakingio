using Core.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Application.ViewModels.BlockChain
{
    public class TransferViewModel
    {
        //public string Password { get; set; }    

        public decimal Amount { get; set; }

        public UnitType Unit { get;set;}

        public string Sponsor { get; set; }
    }
}
