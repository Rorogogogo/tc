using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tc.Data.Base;

public class AppointmentEntity:BaseEntity
{
    public Guid courtId { get; set; }
    public Guid userId { get; set; }
    public Guid activityTypeId { get; set; }
    public string status { get; set; }
    public int type { get; set; }
    public DateTime startTime { get; set; }
    public DateTime endTime { get; set; }


    public AppointmentEntity()
    {
        Id = Guid.NewGuid();
    }
}