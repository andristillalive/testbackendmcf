﻿using System;
using System.Collections.Generic;

namespace BackEndMCF.Models;

public partial class MsUser
{
    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Password { get; set; } = null!;

    public bool IsActive { get; set; }
}
