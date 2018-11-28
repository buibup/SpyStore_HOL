using SpyStore_HOL.Models.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SpyStore_HOL.Models.ViewModels
{
    public class CartRecordWithProductInfo : ProductAndCategoryBase
    {
        [DataType(DataType.Date), Display(Name = "Date Created")]
        public DateTime? DateCreated { get; set; }
        public int? CustomerId { get; set; }
        public int Quantity { get; set; }
        [DataType(DataType.Currency), Display(Name = "Line Total")]
        public decimal LineItemTotal { get; set; }
    }
}
