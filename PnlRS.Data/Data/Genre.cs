using System;
using System.Collections.Generic;

namespace PnlRS.Data.Data;

public partial class Genre
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? Active { get; set; }

    public virtual ICollection<FilmGenre> FilmGenres { get; set; } = new List<FilmGenre>();
}
