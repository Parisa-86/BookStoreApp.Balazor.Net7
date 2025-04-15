using System;
using System.Collections.Generic;

namespace BookStoreApp.api1.Data;

public partial class Author
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Bio { get; set; }

    public virtual ICollection<Book> Books { get; } = new List<Book>();
}
