﻿using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDeliveryShop.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Sandwich",
                        Description = "This is the perfect sandwich №1",
                        Category = "Sandwich",
                        Price = 10
                    },
                    new Product
                    {
                        Name = "Pizza",
                        Description = "This is the perfect pizza №1",
                        Category = "Pizza",
                        Price = 16.5M
                    },
                    new Product
                    {
                        Name = "Beer",
                        Description = "This is the perfect beer №1",
                        Category = "Beer",
                        Price = 7.75M
                    },
                    new Product
                    {
                        Name = "Beer",
                        Description = "This is the perfect beer №2",
                        Category = "Beer",
                        Price = 12.9M
                    },
                    new Product
                    {
                        Name = "Sandwich",
                        Description = "This is the perfect sandwich №2",
                        Category = "Sandwich",
                        Price = 5.5M
                    },
                    new Product
                    {
                        Name = "Sandwich",
                        Description = "This is the perfect sandwich №3",
                        Category = "Sandwich",
                        Price = 9
                    },
                    new Product
                    {
                        Name = "Sandwich",
                        Description = "This is the perfect sandwich №4",
                        Category = "Sandwich",
                        Price = 2.5M
                    },
                    new Product
                    {
                        Name = "Sandwich",
                        Description = "This is the perfect sandwich №5",
                        Category = "Sandwich",
                        Price = 17
                    },
                    new Product
                    {
                        Name = "Pizza",
                        Description = "This is the perfect pizza №2",
                        Category = "Pizza",
                        Price = 28
                    });
                context.SaveChanges();
            }
        }
    }
}
