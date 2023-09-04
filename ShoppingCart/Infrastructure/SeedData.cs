using System;
using Microsoft.EntityFrameworkCore;
using ShoppingCart.Models;

namespace ShoppingCart.Infrastructure
{
    public class SeedData
    {
        public static void SeedDatabase(DataContext context)
        {
            context.Database.Migrate();

            if(!context.Products.Any())
            {
                Category fruits = new Category{Name="Fruits", Slug="fruits"};
                Category vegetables = new Category{Name="Vegetables", Slug="vegetables"};
                Category meat = new Category{Name="Meat", Slug="meat"};
                Category drinks = new Category{Name="Drink", Slug="drinks"};
                Category desserts = new Category{Name="Dessert", Slug="dessert"};
                
                context.Products.AddRange(
                    new Product{
                        Name = "Apple",
                        Slug = "apples",
                        Price = 100,
                        Description = "Apple is a fruit",
                        Category = fruits,
                        Image = "https://source.unsplash.com/random/300%C3%97300"
                    }, 
                    new Product{
                        Name = "Orange",
                        Slug = "oranges",
                        Price = 200,
                        Description = "Orange is a fruit",
                        Category = fruits,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    }, 
                    new Product{
                        Name = "Banana",
                        Slug = "bananas",
                        Price = 300,
                        Description = "Banana is a fruit",
                        Category = fruits,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Carrot",
                        Slug = "carrot",
                        Price = 400,
                        Description = "Carrot is a vegetable",
                        Category = vegetables,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Potato",
                        Slug = "potato",
                        Price = 500,
                        Description = "Potato is a vegetable",
                        Category = vegetables,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Cabbage",
                        Slug = "coral",
                        Price = 600,
                        Description = "Cabbage is a vegetable",
                        Category = vegetables,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Tomato",
                        Slug = "tomatoes",
                        Price = 700,
                        Description = "Tomato is a vegetable",
                        Category = vegetables,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Pineapple",
                        Slug = "pineapple",
                        Price = 800,
                        Description = "Pineapple is a meat",
                        Category = meat,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Chicken",
                        Slug = "chicken",
                        Price = 900,
                        Description = "Chicken is a meat",
                        Category = meat,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Pork",
                        Slug = "pork",
                        Price = 1000,
                        Description = "Pork is a meat",
                        Category = meat,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Beef",
                        Slug = "bean",
                        Price = 1100,
                        Description = "Beef is a meat",
                        Category = meat,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Rice",
                        Slug = "rice",
                        Price = 1200,
                        Description = "Rice is a meat",
                        Category = meat,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Water",
                        Slug = "water",
                        Price = 1300,
                        Description = "Water is a drink",
                        Category = drinks,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Milk",
                        Slug = "milk",
                        Price = 1400,
                        Description = "Milk is a drink",
                        Category = drinks,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Coffee",
                        Slug = "coffee",
                        Price = 1500,
                        Description = "Coffee is a drink",
                        Category = drinks,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Tea",
                        Slug = "tea",
                        Price = 1600,
                        Description = "Tea is a dessert",
                        Category = desserts,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    },
                    new Product{
                        Name = "Cappuccino",
                        Slug = "cappuccino",
                        Price = 1700,
                        Description = "Cappuccino is a dessert",
                        Category = desserts,
                        Image = "https://source.unsplash.com/random/300%C3%97300"

                    }
                );

            }
            context.SaveChanges();
        }
        
    }
}