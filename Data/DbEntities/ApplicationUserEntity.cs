using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;


public class ApplicationUserEntity : IdentityUser<Guid>
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreateDate { get; set; } = DateTime.Now;

    public DateTime? EditDate { get; set; }

    public DateTime? DeleteDate { get; set; }

}