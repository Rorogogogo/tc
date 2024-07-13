using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tc.Data.Base;

public class VenueEntity:BaseEntity
{
    public string Name { get; set; }

    public VenueEntity()
    {
        Id = Guid.NewGuid();
    }
}