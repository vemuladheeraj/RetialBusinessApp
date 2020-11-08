using System;
using System.Collections.Generic;

namespace RetialBusinessApp.Models
{
    public class RetailModel
    {
        public string RetailerShopName { get; set; }
        public string OperatedSince { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string RetailerArea { get; set; }
        public string Pincode { get; set; }
        public string FranchiseArea { get; set; }
        public string RetailerCategory { get; set; }
        public string Essential { get; set; }
        public string FPV { get; set; }
        public string Branded { get; set; }
        public string MonthlyTurnover { get; set; }
        public string CurrentSuppliers { get; set; }
        public string CometitorMonthlyPurchase { get; set; }
        public string OnboardingSSK { get; set; }
        public string Comments { get; set; }
        public string KYC { get; set; }
        public string RegistrationNumber { get; set; }
    }

    public enum OperatedSince
    {
        LessThan6Months,
        SixMonthsToTwoYears,
        TwoToFiveYears,
        FiveToTenYears,
        MoreThanTenYears
    }
}
