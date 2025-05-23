﻿using System;
using System.Collections.Generic;

namespace BookStoreApp.api1.Data;

public partial class Book
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public int? Year { get; set; }

    public string? Summary { get; set; }

    public decimal? Price { get; set; }

    public int? AuthorId { get; set; }

    public int Isbn { get; set; }

    public virtual Author? Author { get; set; }
}
