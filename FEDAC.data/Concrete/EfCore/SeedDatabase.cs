using System.Linq;
using FEDAC.entity;
using Microsoft.EntityFrameworkCore;

namespace FEDAC.data.Concrete.EfCore
{
    public static class SeedDatabase
    {
        public static void Seed()
        {
            var context = new ShopContext();

            if (context.Database.GetPendingMigrations().Count() == 0)
            {
                if (context.Categories.Count() == 0)
                {
                    context.Categories.AddRange(Categories);
                }

                if (context.Products.Count() == 0)
                {
                    context.Products.AddRange(Products);
                    context.AddRange(ProductCategories);//addrange ile productcategoriesi tanıttık.ilişkili olan kısımı tanıttık.
                }
            }
            context.SaveChanges();
        }
//url ekledik cunku url de turkce karakter ve bosluk gibi kısımlar cikmayabilir.
        private static Category[] Categories = {
            new Category(){Name="Telefon",Url="telefon"},
            new Category(){Name="Bilgisayar",Url="bilgisayar"},
            new Category(){Name="Elektronik",Url="elektronik"},
            new Category(){Name="Beyaz Eşya",Url="beyaz-esya"}
        };

        private static Product[] Products = {
            new Product(){Name="Samsung S8 Plus",Url="samsung-s8-plus",Price=2000,ImageUrl="1.jpg",Description="İyi güncel telefon", IsApproved=true},
            new Product(){Name="Samsung S10",Url="samsung-s10",Price=4500,ImageUrl="2.jpg",Description="İyi kaliteli telefon", IsApproved=false},
            new Product(){Name="Iphone 8 Plus",Url="iphone-8-plus",Price=10000,ImageUrl="3.jpg",Description="İyi telefon", IsApproved=true},
            new Product(){Name="Xaomi Mi 10",Url="xaomi-mi-10",Price=8000,ImageUrl="4.jpg",Description="güzel telefon", IsApproved=true},
            new Product(){Name="Huawei P40",Url="Huawei-p40",Price=6000,ImageUrl="1.jpg",Description="mükemmel telefon", IsApproved=false},

        };
//productları categorylerle ilişkilendirdik.
        private static ProductCategory[] ProductCategories={
            new ProductCategory(){Product=Products[0],Category=Categories[0]},
            new ProductCategory(){Product=Products[0],Category=Categories[2]},
            new ProductCategory(){Product=Products[1],Category=Categories[0]},
            new ProductCategory(){Product=Products[1],Category=Categories[2]},
            new ProductCategory(){Product=Products[2],Category=Categories[0]},
            new ProductCategory(){Product=Products[2],Category=Categories[2]},
            new ProductCategory(){Product=Products[3],Category=Categories[0]},
            new ProductCategory(){Product=Products[3],Category=Categories[2]},
        };
    }
}