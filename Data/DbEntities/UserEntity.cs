using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using tc.Data.Base;

public class UserEneity:BaseEntity
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string memberType { get; set; }


    public UserEneity()
    {
        Id = Guid.NewGuid();
    }
}