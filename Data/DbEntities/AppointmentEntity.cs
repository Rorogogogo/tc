using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tc.Data.Base;

public class AppointmentEntity : BaseEntity
{
    [Required]
    [ForeignKey("Venue")]
    public Guid VenueId { get; set; }

    [Required]
    [ForeignKey("User")]
    public Guid UserId { get; set; }

    [Required]
    [ForeignKey("ActivityType")]
    public Guid ActivityTypeId { get; set; }

    [Required]
    public string Status { get; set; }

    [Required]
    public DateTime StartTime { get; set; }

    [Required]
    [CustomValidation(typeof(AppointmentEntity), nameof(ValidateEndTime))]
    public DateTime EndTime { get; set; }

    public virtual VenueEntity Venue { get; set; }
    public virtual ApplicationUserEntity User { get; set; }
    public virtual ActivityTypeEntity ActivityType { get; set; }

    public AppointmentEntity()
    {
        Id = Guid.NewGuid();
    }

    // Custom validation method for EndTime
    public static ValidationResult ValidateEndTime(DateTime endTime, ValidationContext context)
    {
        var instance = context.ObjectInstance as AppointmentEntity;
        if (instance != null && endTime < instance.StartTime)
        {
            return new ValidationResult("EndTime cannot be earlier than StartTime.");
        }
        return ValidationResult.Success;
    }
}
