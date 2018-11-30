using SpyStore_HOL.MVC.Validation;
using SpyStore_HOL.MVC.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpyStore_HOL.MVC.ViewModels
{
    public class AddToCartViewModel : CartViewModelBase
    {
        [MustNotBeGreaterThan(nameof(UnitsInStock)), MustBeGreaterThanZero]
        public int Quantity { get; set; }
    }
}
