using System;
using System.Collections.Generic;

namespace BackEndMCF.Models;

public partial class MsLocationStorage
{
    public string LocationId { get; set; } = null!;

    public string LocationName { get; set; } = null!;

    public virtual ICollection<TrBpkb> TrBpkbs { get; set; } = new List<TrBpkb>();
}
