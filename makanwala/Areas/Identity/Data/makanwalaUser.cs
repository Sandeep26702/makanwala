using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace makanwala.Areas.Identity.Data;

// Add profile data for application users by adding properties to the makanwalaUser class
public class makanwalaUser : IdentityUser
{
    public string FullName { get; set; } = string.Empty;  // Ensure non-null default value
}

