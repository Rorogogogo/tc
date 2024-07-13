using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tc.Data.Base;

public class ActivityTypeEntity:BaseEntity
{
    public string activityName { get; set; }


    public ActivityTypeEntity()
    {
        Id = Guid.NewGuid();
    }
}