﻿using Microsoft.EntityFrameworkCore;
using SimpleApi.Domain.Entitys;
using SimpleApi.Infra.Data.Interfaces;

namespace SimpleApi.Infra.Data.Contexts;

public class SimpleApiContext : DbContext, ISimpleApiContext
{
    public DbSet<Book> Books { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5442;Database=SimpleApi;Username=postgres;Password=postgres");
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.AddConfigureModels();
    }
}