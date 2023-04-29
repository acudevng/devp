using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ACU.Portals.Apply.Pages.ACUPay
{
    [Authorize(Policy="PaidPolicy")]
	public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
