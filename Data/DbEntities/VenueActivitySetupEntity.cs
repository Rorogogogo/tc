using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tc.Data.Base;

public class VenueActivitySetupEntity : BaseEntity
{
    public Guid VenueId { get; set; }
    public Guid UserId { get; set; }
    public string Scene { get; set; }
    public int OnSceneOffset { get; set; }
    public int OffSceneOffset { get; set; }


    public VenueActivitySetupEntity()
    {
        Id = Guid.NewGuid();
    }
}