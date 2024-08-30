﻿using Microsoft.EntityFrameworkCore;

namespace CSnakesAspire.ApiService;

public class WeatherDbContext(DbContextOptions<WeatherDbContext> options) : DbContext(options)
{
    public DbSet<Weather> WeatherForecasts { get; set; }
}