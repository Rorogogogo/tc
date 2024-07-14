using Microsoft.AspNetCore.Identity;


public class ApplicationUserEntity : IdentityUser
{
    public string? userType { get; set; }

}