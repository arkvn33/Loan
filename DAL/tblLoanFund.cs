//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblLoanFund
    {
        public byte Id { get; set; }
        public string LoanFundName { get; set; }
        public string LoanFundTell1 { get; set; }
        public string LoanFundTell2 { get; set; }
        public string LoanFundFax { get; set; }
        public string LoanFundEmail { get; set; }
        public string LoanFundPostalCode { get; set; }
        public string LoanFundAddress { get; set; }
        public Nullable<long> LoanFundInitialBalance { get; set; }
        public Nullable<long> LoanFundPenalty { get; set; }
        public string LoanFundWagePercent { get; set; }
        public string LoanFundLogo { get; set; }
    }
}