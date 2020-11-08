using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RetialBusinessApp.Models
{
    public class RetailModel
    {
        [Required]
        [Display(Name = "Retailer Shop Name")] 
        public string RetailerShopName { get; set; }
        [Display(Name = "Operated Since")]
        public string OperatedSince { get; set; }
        [Display(Name = "Contact Person")]
        public string ContactPerson { get; set; }
        [Display(Name = "Contact Number")]
        public string ContactNumber { get; set; }
        [Display(Name = "Retailer Area")]
        public string RetailerArea { get; set; }
        [Display(Name = "Pincode")]
        public string Pincode { get; set; }
        [Display(Name = "Franchise Area")]
        public string SelectedFranchiseArea { get; set; }
        public IEnumerable<SelectListItem> FranchiseAreas { get; set; }

        [Display(Name = "Retailer Category")]
        public string RetailerCategory { get; set; }
        [Display(Name = "Essential")]
        public string Essential { get; set; }
        [Display(Name = "FPV")]
        public string FPV { get; set; }
        [Display(Name = "Branded")]
        public string Branded { get; set; }
        [Display(Name = "Monthly Turnover")]
        public string MonthlyTurnover { get; set; }
        [Display(Name = "Current Suppliers")]
        public string CurrentSuppliers { get; set; }
        [Display(Name = "Cometitor Monthly Purchase")]
        public string CometitorMonthlyPurchase { get; set; }
        [Display(Name = "Onboarding SSK")]
        public string OnboardingSSK { get; set; }
        [Display(Name = "Comments")]
        public string Comments { get; set; }
        [Display(Name = "KYC")]
        public string KYC { get; set; }
        [Display(Name = "Registration Number")]
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
