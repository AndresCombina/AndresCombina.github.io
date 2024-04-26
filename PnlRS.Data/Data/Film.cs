using System;
using System.Collections.Generic;

namespace PnlRS.Data.Data;

public partial class Film
{
    public int Id { get; set; }

    public int? DirectorId { get; set; }

    public int? LanguageId { get; set; }

    public int? CountryId { get; set; }

    public int? StudioId { get; set; }

    public int? CertificateId { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? ReleaseDate { get; set; }

    public string? Synopsis { get; set; }

    public int RunTimeMinutes { get; set; }

    public int? BudgetDollars { get; set; }

    public int? BoxOfficeDollars { get; set; }

    public int OscarNominations { get; set; }

    public int OscarWins { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<Casting> Castings { get; set; } = new List<Casting>();

    public virtual Certificate? Certificate { get; set; }

    public virtual Country? Country { get; set; }

    public virtual Director? Director { get; set; }

    public virtual ICollection<FilmGenre> FilmGenres { get; set; } = new List<FilmGenre>();

    public virtual Language? Language { get; set; }

    public virtual Studio? Studio { get; set; }
}
