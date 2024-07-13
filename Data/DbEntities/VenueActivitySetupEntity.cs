using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tc.Data.Base;

public class VenueActivitySetupEntity : BaseEntity
{
    public Guid venueId { get; set; }
    public Guid userId { get; set; }
    public string scene { get; set; }
    public int onSceneOffset { get; set; }
    public int offSceneOffset { get; set; }


    public VenueActivitySetupEntity()
    {
        Id = Guid.NewGuid();
    }
}