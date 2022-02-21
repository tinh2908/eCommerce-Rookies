using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Rookie.CustomerSite.ViewModel;
using Rookies.ShareClassdLibrary;

namespace Rookies.CustomerSite.Pages.Product
{
    public class IndexModel : PageModel
    {
        public PagedResponseVM<ProductVM> Products { get; set; }
    }
}
