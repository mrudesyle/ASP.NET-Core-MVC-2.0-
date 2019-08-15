using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LittlePacktBookstore.Components
{
    public class Address: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var addresses = new Models.Address();
            //{
            //    Countries = new List<SelectListItem>
            //        {
            //            new SelectListItem{Value="Country1", Text="Country1", Selected=true},
            //            new SelectListItem{Value="Country2", Text="Country2"},
            //            new SelectListItem{Value="Country3", Text="Country3"},
            //            new SelectListItem{Value="Country4", Text="Country4"},
            //            new SelectListItem{Value="Country5", Text="Country5"}
            //        }
            //};
            return View(addresses);
        }
    }
}
