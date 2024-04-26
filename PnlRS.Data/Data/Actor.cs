using System;
using System.Collections.Generic;

namespace PnlRS.Data.Data;

public partial class Actor
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? Dob { get; set; }

    public bool IsMale { get; set; }

    public bool Deceased { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<Casting> Castings { get; set; } = new List<Casting>();
}
