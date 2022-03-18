using ASPNetCoreIntro.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ASPNetCoreIntro.Models
{
    public class SaveCustomerViewModel
    {
        public Customer Customer { get; set; }
        public List<SelectListItem> Cities { get; set; }
    }
}
