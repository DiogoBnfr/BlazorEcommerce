using BlazorEcommerce.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.API.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Cart>? Carts { get; set; }
    public DbSet<CartItem>? CartItems { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Product>? Products { get; set; }
    public DbSet<User>? Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Categories
        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 1,
            Name = "Mouse",
            Icon = "fas fa-spa"
        });
        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 2,
            Name = "Keyboard",
            Icon = "fas fa-spa"
        });
        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 3,
            Name = "Headset",
            Icon = "fas fa-spa"
        });

        // Products
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 1,
            Name = "Logitech MX Master 3 Wireless",
            Description = "Get work done with the black colored Logitech MX Master 3 Wireless Mouse by your side",
            ImageUrl = "/Images/LogitechMXMaster3Wireless.png",
            Price = 100,
            Quantity = 100,
            CategoryId = 1
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 2,
            Name = "Apple Magic Mouse 2",
            Description = "The Magic Mouse 2 is completely rechargeable, so you’ll eliminate the use of traditional batteries.",
            ImageUrl = "/Images/AppleMagicMouse2.png",
            Price = 79,
            Quantity = 50,
            CategoryId = 1
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 3,
            Name = "Razer DeathAdder V2",
            Description = "The DeathAdder V2 features the fastest, most reliable optical sensor in the industry.",
            ImageUrl = "/Images/RazerDeathAdderV2.png",
            Price = 69,
            Quantity = 80,
            CategoryId = 1
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 4,
            Name = "Corsair Ironclaw RGB Wireless",
            Description = "The Corsair Ironclaw RGB Wireless boasts a 18,000 DPI optical sensor for precision and accuracy.",
            ImageUrl = "/Images/CorsairIronclawRGBWireless.png",
            Price = 79,
            Quantity = 60,
            CategoryId = 1
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 5,
            Name = "SteelSeries Rival 600",
            Description = "The Rival 600 gaming mouse features a 12,000 CPI TrueMove3+ Dual Optical Sensor for ultra-low-latency tracking.",
            ImageUrl = "/Images/SteelSeriesRival600.png",
            Price = 89,
            Quantity = 70,
            CategoryId = 1
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 6,
            Name = "Logitech G502 Hero",
            Description = "The Logitech G502 Hero features the advanced optical sensor for maximum tracking accuracy.",
            ImageUrl = "/Images/LogitechG502Hero.png",
            Price = 79,
            Quantity = 65,
            CategoryId = 1
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 7,
            Name = "Razer BlackWidow Elite",
            Description = "The Razer BlackWidow Elite mechanical gaming keyboard offers full RGB customization.",
            ImageUrl = "/Images/RazerBlackWidowElite.png",
            Price = 129,
            Quantity = 40,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 8,
            Name = "Corsair K95 RGB Platinum XT",
            Description = "The Corsair K95 RGB Platinum XT mechanical gaming keyboard features CHERRY MX keyswitches and a detachable wrist rest.",
            ImageUrl = "/Images/CorsairK95RGBPlatinumXT.png",
            Price = 179,
            Quantity = 30,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 9,
            Name = "Logitech G Pro X Mechanical Keyboard",
            Description = "The Logitech G Pro X mechanical gaming keyboard comes with swappable pro-grade switches.",
            ImageUrl = "/Images/LogitechGProXMechanicalKeyboard.png",
            Price = 149,
            Quantity = 35,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 10,
            Name = "Apple Magic Keyboard",
            Description = "The Magic Keyboard combines a sleek design with a built-in rechargeable battery.",
            ImageUrl = "/Images/AppleMagicKeyboard.png",
            Price = 99,
            Quantity = 50,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 11,
            Name = "SteelSeries Apex Pro",
            Description = "The SteelSeries Apex Pro mechanical gaming keyboard features adjustable mechanical switches for customizable actuation.",
            ImageUrl = "/Images/SteelSeriesApexPro.png",
            Price = 199,
            Quantity = 25,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 12,
            Name = "Ducky One 2 Mini",
            Description = "The Ducky One 2 Mini mechanical keyboard offers a compact 60% layout with customizable RGB lighting.",
            ImageUrl = "/Images/DuckyOne2Mini.png",
            Price = 119,
            Quantity = 20,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 13,
            Name = "HyperX Alloy Origins Core",
            Description = "The HyperX Alloy Origins Core mechanical gaming keyboard features HyperX Red switches and customizable RGB lighting.",
            ImageUrl = "/Images/HyperXAlloyOriginsCore.png",
            Price = 89,
            Quantity = 45,
            CategoryId = 2
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 14,
            Name = "SteelSeries Arctis 7 Wireless",
            Description = "The SteelSeries Arctis 7 Wireless gaming headset features 2.4GHz wireless connectivity and ClearCast microphone.",
            ImageUrl = "/Images/SteelSeriesArctis7Wireless.png",
            Price = 149,
            Quantity = 30,
            CategoryId = 3
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 15,
            Name = "HyperX Cloud II",
            Description = "The HyperX Cloud II gaming headset comes with 7.1 virtual surround sound and a detachable microphone.",
            ImageUrl = "/Images/HyperXCloudII.png",
            Price = 99,
            Quantity = 40,
            CategoryId = 3
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 16,
            Name = "Logitech G Pro X Gaming Headset",
            Description = "The Logitech G Pro X gaming headset features Blue Voice microphone technology for clear communication.",
            ImageUrl = "/Images/LogitechGProXGamingHeadset.png",
            Price = 129,
            Quantity = 35,
            CategoryId = 3
        });
        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 17,
            Name = "Corsair HS70 Wireless",
            Description = "The Corsair HS70 Wireless gaming headset offers 2.4GHz wireless connectivity and custom-tuned 50mm neodymium speaker drivers.",
            ImageUrl = "/Images/CorsairHS70Wireless.png",
            Price = 99,
            Quantity = 25,
            CategoryId = 3
        });

        // Users
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            Name = "Bob Foo"
        });
        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 2,
            Name = "John Bar"
        });

        // Carts
        modelBuilder.Entity<Cart>().HasData(new Cart
        {
            Id = 1,
            UserId = 1
        });
        modelBuilder.Entity<Cart>().HasData(new Cart
        {
            Id = 2,
            UserId = 2
        });
    }
}