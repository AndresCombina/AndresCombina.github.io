using System;
using System.Collections.Generic;

namespace PnlRS.Data.Data;

public partial class Casting
{
    public int Id { get; set; }

    public int FilmId { get; set; }

    public int ActorId { get; set; }

    public string? CharacterName { get; set; }

    public bool? Active { get; set; }

    public virtual Actor Actor { get; set; } = null!;

    public virtual Film Film { get; set; } = null!;
}
