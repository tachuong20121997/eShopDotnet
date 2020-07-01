using eShopSolution.Data.Entities.Shop;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Entities.System
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
