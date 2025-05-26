﻿using System;
using System.Collections.Generic;

namespace project1.Models;

public partial class Member
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public virtual ICollection<BookCheckout> BookCheckouts { get; set; } = new List<BookCheckout>();
}
