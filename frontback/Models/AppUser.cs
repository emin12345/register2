using System;
using Microsoft.AspNetCore.Identity;

namespace frontback.Models;

public class AppUser:IdentityUser
{
	public string Fullname { get; set; }
	public bool IsActive { get; set; }
}

