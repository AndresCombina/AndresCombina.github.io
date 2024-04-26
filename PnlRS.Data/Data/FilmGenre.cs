using System;
using System.Collections.Generic;

namespace PnlRS.Data.Data;

public partial class FilmGenre
{
    public int Id { get; set; }

    public int FilmId { get; set; }

    public int GenreId { get; set; }

    public virtual Film Film { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;
}
