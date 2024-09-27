using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace _41505212__API.Models;

public partial class AspNetRoleClaim
{
    public int Id { get; set; }

    public string RoleId { get; set; } = null!;

    public string? ClaimType { get; set; }

    public string? ClaimValue { get; set; }

    public virtual IdentityRole Role { get; set; } = null!;
}
