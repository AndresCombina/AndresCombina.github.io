using System;
using System.Collections.Generic;

namespace PnlRS.Data.Data;

public partial class Director
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public DateTime? Dob { get; set; }

    public bool IsMale { get; set; }

    public bool Deceased { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<Film> Films { get; set; } = new List<Film>();
}
