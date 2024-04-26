using System;
using System.Collections.Generic;

namespace PnlRS.Data.Data;

public partial class Country
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<Film> Films { get; set; } = new List<Film>();
}
