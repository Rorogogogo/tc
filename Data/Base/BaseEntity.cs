using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tc.Data.Base;
public class BaseEntity
{
    [Key]
    [Required]
    public Guid Id { get; set; }

    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public DateTime CreateDate { get; set; } = DateTime.Now;

    public DateTime? EditDate { get; set; }

    public DateTime? DeleteDate { get; set; }
}