using FurnitureStoreApp.Data;
using FurnitureStoreApp.Forms;
using FurnitureStoreApp.Models;

namespace FurnitureStoreApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
           // ApplicationConfiguration.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new RoleForm());
            Application.Run(new WelcomeForm());
            //Application.Run(new LogInForm());
            using (var context = new FurnitureStoreContext())
            {
                //    // Insert Categories
                //    var category1 = new Category { Name = "Sofa" };
                //    var category2 = new Category { Name = "Chairs" };
                //    var category3 = new Category { Name = "Tables" };
                //    var category4 = new Category { Name = "Rattan" };

                //    context.Categories.AddRange(category1, category2, category3);

                //    // Insert Products
                //    var product1 = new Product
                //    {
                //        Name = "Boho Chair ",
                //        Price = 12495,
                //        StockQuantity = 10,
                //        ImagePath = "Images\\Chair.jpg"

                //    };
                //    var product2 = new Product
                //    {
                //        Name = "Ria Table ",
                //        Price = 10500,
                //        StockQuantity = 7,
                //        ImagePath = "Images\\SideTable.jpg"

                //    };

                //    var product3 = new Product
                //    {
                //        Name = "Vanity Table",
                //        Price = 10500,
                //        StockQuantity = 7,
                //        ImagePath = "Images\\rr.jpg"

                //    };
                //    var product4 = new Product
                //    {
                //        Name = "Sofa",
                //        Price = 10500,
                //        StockQuantity = 7,
                //        ImagePath = "Images\\sofa.jpg"

                //    };

                //    context.Products.AddRange(product1, product2, product3, product4);


                //    // Map Products to Categories
                //    context.ProductsCategories.Add(new ProductsCategories
                //    {
                //        Product = product1,
                //        Category = category2
                //    });
                //    context.ProductsCategories.Add(new ProductsCategories
                //    {
                //        Product = product2,
                //        Category = category3
                //    });
                //    context.ProductsCategories.Add(new ProductsCategories
                //    {
                //        Product = product3,
                //        Category = category3
                //    });
                //    context.ProductsCategories.Add(new ProductsCategories
                //    {
                //        Product = product3,
                //        Category = category4
                //    });
                //    context.ProductsCategories.Add(new ProductsCategories
                //    {
                //        Product = product4,
                //        Category = category1
                //    });
                //    context.ProductsCategories.Add(new ProductsCategories
                //    {
                //        Product = product4,
                //        Category = category4
                //    });

                //    // Insert Users
                //    var user = new User
                //    {
                //        Email = "customer1",
                //        Password = "password123",
                //        Role = "Customer"
                //    };

                //    context.Users.Add(user);

                //    context.SaveChanges();
                //    Console.WriteLine("Data inserted successfully.");
                //}

                //// Insert Users
                ////var user = new User
                ////{
                ////    Email = "Shahd",
                ////    Password = "171",
                ////    Role = "Admin"
                ////};

                ////context.Users.Add(user);

                ////context.SaveChanges();
            }
        }
    }
}