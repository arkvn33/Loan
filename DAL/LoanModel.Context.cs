﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbLoanEntities : DbContext
    {
        public dbLoanEntities()
            : base("name=dbLoanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblAccount> tblAccount { get; set; }
        public virtual DbSet<tblAccountType> tblAccountType { get; set; }
        public virtual DbSet<tblBankAccount> tblBankAccount { get; set; }
        public virtual DbSet<tblBlockType> tblBlockType { get; set; }
        public virtual DbSet<tblChargeMonthly> tblChargeMonthly { get; set; }
        public virtual DbSet<tblChMoPay> tblChMoPay { get; set; }
        public virtual DbSet<tblFeeIncome> tblFeeIncome { get; set; }
        public virtual DbSet<tblFeeIncomeType> tblFeeIncomeType { get; set; }
        public virtual DbSet<tblGuaranteeType> tblGuaranteeType { get; set; }
        public virtual DbSet<tblGuarantor> tblGuarantor { get; set; }
        public virtual DbSet<tblInfo> tblInfo { get; set; }
        public virtual DbSet<tblInstallment> tblInstallment { get; set; }
        public virtual DbSet<tblInstitution> tblInstitution { get; set; }
        public virtual DbSet<tblIntroducer> tblIntroducer { get; set; }
        public virtual DbSet<tblIntroducerType> tblIntroducerType { get; set; }
        public virtual DbSet<tblLicense> tblLicense { get; set; }
        public virtual DbSet<tblLoan> tblLoan { get; set; }
        public virtual DbSet<tblLoanFund> tblLoanFund { get; set; }
        public virtual DbSet<tblLoanType> tblLoanType { get; set; }
        public virtual DbSet<tblPaymentType> tblPaymentType { get; set; }
        public virtual DbSet<tblPerAccType> tblPerAccType { get; set; }
        public virtual DbSet<tblPersonnel> tblPersonnel { get; set; }
        public virtual DbSet<tblPostType> tblPostType { get; set; }
        public virtual DbSet<tblSecurityAccess> tblSecurityAccess { get; set; }
        public virtual DbSet<tblSecurityQuestion> tblSecurityQuestion { get; set; }
        public virtual DbSet<tblSundry> tblSundry { get; set; }
        public virtual DbSet<tblTransactionType> tblTransactionType { get; set; }
        public virtual DbSet<tblUser> tblUser { get; set; }
        public virtual DbSet<tblWage> tblWage { get; set; }
        public virtual DbSet<tblWageCalculationType> tblWageCalculationType { get; set; }
        public virtual DbSet<tblWageType> tblWageType { get; set; }
        public virtual DbSet<viewAccountInfo> viewAccountInfo { get; set; }
        public virtual DbSet<viewChMoPayInfo> viewChMoPayInfo { get; set; }
        public virtual DbSet<viewFeeIncomeInfo> viewFeeIncomeInfo { get; set; }
        public virtual DbSet<viewInsLoan> viewInsLoan { get; set; }
        public virtual DbSet<viewLoanInfo> viewLoanInfo { get; set; }
        public virtual DbSet<viewPersonnelInfo> viewPersonnelInfo { get; set; }
    
        public virtual ObjectResult<spAllData_Result> spAllData()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spAllData_Result>("spAllData");
        }
    
        public virtual ObjectResult<Nullable<int>> spAutoAccountId()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spAutoAccountId");
        }
    
        public virtual ObjectResult<Nullable<int>> spAutoPersonnelId()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("spAutoPersonnelId");
        }
    
        public virtual ObjectResult<Nullable<long>> spPerCanGetMoney(Nullable<int> personnelId, Nullable<int> infoId)
        {
            var personnelIdParameter = personnelId.HasValue ?
                new ObjectParameter("PersonnelId", personnelId) :
                new ObjectParameter("PersonnelId", typeof(int));
    
            var infoIdParameter = infoId.HasValue ?
                new ObjectParameter("InfoId", infoId) :
                new ObjectParameter("InfoId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<long>>("spPerCanGetMoney", personnelIdParameter, infoIdParameter);
        }
    
        public virtual ObjectResult<spPeriodAllData_Result> spPeriodAllData(string startDate, string endDate)
        {
            var startDateParameter = startDate != null ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(string));
    
            var endDateParameter = endDate != null ?
                new ObjectParameter("EndDate", endDate) :
                new ObjectParameter("EndDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spPeriodAllData_Result>("spPeriodAllData", startDateParameter, endDateParameter);
        }
    
        public virtual ObjectResult<spSelectAccountInfo_Result> spSelectAccountInfo(Nullable<int> personnelId)
        {
            var personnelIdParameter = personnelId.HasValue ?
                new ObjectParameter("PersonnelId", personnelId) :
                new ObjectParameter("PersonnelId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelectAccountInfo_Result>("spSelectAccountInfo", personnelIdParameter);
        }
    
        public virtual ObjectResult<spSelectChMoPayInfo_Result> spSelectChMoPayInfo(Nullable<int> personnelId)
        {
            var personnelIdParameter = personnelId.HasValue ?
                new ObjectParameter("PersonnelId", personnelId) :
                new ObjectParameter("PersonnelId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelectChMoPayInfo_Result>("spSelectChMoPayInfo", personnelIdParameter);
        }
    
        public virtual ObjectResult<spSelectFeeIncomeInfo_Result> spSelectFeeIncomeInfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelectFeeIncomeInfo_Result>("spSelectFeeIncomeInfo");
        }
    
        public virtual ObjectResult<spSelectLoanInfo_Result> spSelectLoanInfo(Nullable<int> personnelId)
        {
            var personnelIdParameter = personnelId.HasValue ?
                new ObjectParameter("PersonnelId", personnelId) :
                new ObjectParameter("PersonnelId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelectLoanInfo_Result>("spSelectLoanInfo", personnelIdParameter);
        }
    
        public virtual ObjectResult<spSelectPersonnelInfo_Result> spSelectPersonnelInfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spSelectPersonnelInfo_Result>("spSelectPersonnelInfo");
        }
    
        public virtual int spSortAccount(Nullable<int> account_Personnel_Id)
        {
            var account_Personnel_IdParameter = account_Personnel_Id.HasValue ?
                new ObjectParameter("Account_Personnel_Id", account_Personnel_Id) :
                new ObjectParameter("Account_Personnel_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spSortAccount", account_Personnel_IdParameter);
        }
    
        public virtual int spUpdateAccountCurrentBalance(Nullable<int> personnelId)
        {
            var personnelIdParameter = personnelId.HasValue ?
                new ObjectParameter("PersonnelId", personnelId) :
                new ObjectParameter("PersonnelId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateAccountCurrentBalance", personnelIdParameter);
        }
    }
}
