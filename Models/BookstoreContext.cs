﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookStore.Models;

public partial class BookstoreContext : DbContext
{
    public BookstoreContext()
    {
    }
    public BookstoreContext(DbContextOptions<BookstoreContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Book> Books { get; set; }
}
