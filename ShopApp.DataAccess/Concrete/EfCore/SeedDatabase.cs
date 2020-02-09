using Microsoft.EntityFrameworkCore;
using ShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShopApp.DataAccess.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {

            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count()==0)
            {
                if(context.Categories.Count()==0)
                {
                    context.Categories.AddRange(Categories);
                }
                if(context.Products.Count()==0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategory);
                }
                context.SaveChanges();
            }
        }

        private static Category[] Categories =
        {
            new Category() { Name = "Sebze"},
            new Category() { Name = "Meyve"},
            new Category() { Name = "Bakliyat"}

        };

        private static Product[] Products =
        {
            new Product(){Name = "Domates", Price=5, ImageUrl="1.jpg", Description= "<p>yüzde yüz yerli tire domat organik</p>"},
            new Product(){Name = "Havuç", Price=3, ImageUrl="2.jpg", Description= "<p>yüzde yüz yerli tire havuç organik</p>"},
            new Product(){Name = "Patates", Price=4, ImageUrl="3.jpg", Description= "<p>yüzde yüz yerli tire patates organik</p>"},
            new Product(){Name = "Salatalık", Price=6, ImageUrl="4.jpg", Description= "<p>yüzde yüz yerli tire salatalık organik</p>"},
            new Product(){Name = "Taze Fasulye", Price=10, ImageUrl="5.jpg", Description= "<p>yüzde yüz yerli tire fasulye organik</p>"},
            new Product(){Name = "meyve", Price=3, ImageUrl="1.jpg", Description= "<p>yüzde yüz yerli tire domat organik</p>"},
            new Product(){Name = "meyve", Price=3, ImageUrl="1.jpg", Description= "<p>yüzde yüz yerli tire domat organik</p>"}
        };
        private static ProductCategory[] ProductCategory =
        {
            new ProductCategory() { Product= Products[0],Category= Categories[0]},
            new ProductCategory() { Product= Products[0],Category= Categories[2]},
            new ProductCategory() { Product= Products[1],Category= Categories[0]},
            new ProductCategory() { Product= Products[1],Category= Categories[1]},
            new ProductCategory() { Product= Products[2],Category= Categories[0]},
            new ProductCategory() { Product= Products[2],Category= Categories[2]},
            new ProductCategory() { Product= Products[3],Category= Categories[1]}
        };
    }
}
