using System;
using System.Collections.Generic;

namespace MyFirstEFCore.Domain;

public partial class Test
{
    public string Testid { get; set; } = null!;

    public virtual ICollection<Score> Scores { get; set; } = new List<Score>();
}
