using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.API.Migrations {
    /// <inheritdoc />
    public partial class Initial : Migration {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Icon", "Name" },
                values: new object[,]
                {
                    { 1, "fas fa-spa", "Mouse" },
                    { 2, "fas fa-spa", "Keyboard" },
                    { 3, "fas fa-spa", "Headset" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bob Foo" },
                    { 2, "John Bar" }
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, "Get work done with the black colored Logitech MX Master 3 Wireless Mouse by your side", "/Images/LogitechMXMaster3Wireless.png", "Logitech MX Master 3 Wireless", 100m, 100 },
                    { 2, 1, "The Magic Mouse 2 is completely rechargeable, so you’ll eliminate the use of traditional batteries.", "/Images/AppleMagicMouse2.png", "Apple Magic Mouse 2", 79m, 50 },
                    { 3, 1, "The DeathAdder V2 features the fastest, most reliable optical sensor in the industry.", "/Images/RazerDeathAdderV2.png", "Razer DeathAdder V2", 69m, 80 },
                    { 4, 1, "The Corsair Ironclaw RGB Wireless boasts a 18,000 DPI optical sensor for precision and accuracy.", "/Images/CorsairIronclawRGBWireless.png", "Corsair Ironclaw RGB Wireless", 79m, 60 },
                    { 5, 1, "The Rival 600 gaming mouse features a 12,000 CPI TrueMove3+ Dual Optical Sensor for ultra-low-latency tracking.", "/Images/SteelSeriesRival600.png", "SteelSeries Rival 600", 89m, 70 },
                    { 6, 1, "The Logitech G502 Hero features the advanced optical sensor for maximum tracking accuracy.", "/Images/LogitechG502Hero.png", "Logitech G502 Hero", 79m, 65 },
                    { 7, 2, "The Razer BlackWidow Elite mechanical gaming keyboard offers full RGB customization.", "/Images/RazerBlackWidowElite.png", "Razer BlackWidow Elite", 129m, 40 },
                    { 8, 2, "The Corsair K95 RGB Platinum XT mechanical gaming keyboard features CHERRY MX keyswitches and a detachable wrist rest.", "/Images/CorsairK95RGBPlatinumXT.png", "Corsair K95 RGB Platinum XT", 179m, 30 },
                    { 9, 2, "The Logitech G Pro X mechanical gaming keyboard comes with swappable pro-grade switches.", "/Images/LogitechGProXMechanicalKeyboard.png", "Logitech G Pro X Mechanical Keyboard", 149m, 35 },
                    { 10, 2, "The Magic Keyboard combines a sleek design with a built-in rechargeable battery.", "/Images/AppleMagicKeyboard.png", "Apple Magic Keyboard", 99m, 50 },
                    { 11, 2, "The SteelSeries Apex Pro mechanical gaming keyboard features adjustable mechanical switches for customizable actuation.", "/Images/SteelSeriesApexPro.png", "SteelSeries Apex Pro", 199m, 25 },
                    { 12, 2, "The Ducky One 2 Mini mechanical keyboard offers a compact 60% layout with customizable RGB lighting.", "/Images/DuckyOne2Mini.png", "Ducky One 2 Mini", 119m, 20 },
                    { 13, 2, "The HyperX Alloy Origins Core mechanical gaming keyboard features HyperX Red switches and customizable RGB lighting.", "/Images/HyperXAlloyOriginsCore.png", "HyperX Alloy Origins Core", 89m, 45 },
                    { 14, 3, "The SteelSeries Arctis 7 Wireless gaming headset features 2.4GHz wireless connectivity and ClearCast microphone.", "/Images/SteelSeriesArctis7Wireless.png", "SteelSeries Arctis 7 Wireless", 149m, 30 },
                    { 15, 3, "The HyperX Cloud II gaming headset comes with 7.1 virtual surround sound and a detachable microphone.", "/Images/HyperXCloudII.png", "HyperX Cloud II", 99m, 40 },
                    { 16, 3, "The Logitech G Pro X gaming headset features Blue Voice microphone technology for clear communication.", "/Images/LogitechGProXGamingHeadset.png", "Logitech G Pro X Gaming Headset", 129m, 35 },
                    { 17, 3, "The Corsair HS70 Wireless gaming headset offers 2.4GHz wireless connectivity and custom-tuned 50mm neodymium speaker drivers.", "/Images/CorsairHS70Wireless.png", "Corsair HS70 Wireless", 99m, 25 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
