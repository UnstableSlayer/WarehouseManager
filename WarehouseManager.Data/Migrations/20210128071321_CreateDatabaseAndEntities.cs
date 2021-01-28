using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WarehouseManager.Data.Migrations
{
    public partial class CreateDatabaseAndEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "actr");

            migrationBuilder.EnsureSchema(
                name: "actrt");

            migrationBuilder.EnsureSchema(
                name: "bnd");

            migrationBuilder.EnsureSchema(
                name: "cnt");

            migrationBuilder.EnsureSchema(
                name: "crc");

            migrationBuilder.EnsureSchema(
                name: "emp");

            migrationBuilder.EnsureSchema(
                name: "jbp");

            migrationBuilder.EnsureSchema(
                name: "mfr");

            migrationBuilder.EnsureSchema(
                name: "org");

            migrationBuilder.EnsureSchema(
                name: "orgt");

            migrationBuilder.EnsureSchema(
                name: "prdc");

            migrationBuilder.EnsureSchema(
                name: "prd");

            migrationBuilder.EnsureSchema(
                name: "prdt");

            migrationBuilder.EnsureSchema(
                name: "wrh");

            migrationBuilder.CreateTable(
                name: "AccountentTreeTypes",
                schema: "actrt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountentTreeTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                schema: "bnd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "cnt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                schema: "crc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OtherCurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobPositions",
                schema: "jbp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                schema: "mfr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrganizationTypes",
                schema: "orgt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrganizationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                schema: "prdc",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                schema: "prdt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountentTree",
                schema: "actr",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentTreeId = table.Column<int>(type: "int", nullable: true),
                    TreeTypeId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountentTree", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountentTree_AccountentTree_ParentTreeId",
                        column: x => x.ParentTreeId,
                        principalSchema: "actr",
                        principalTable: "AccountentTree",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AccountentTree_AccountentTreeTypes_TreeTypeId",
                        column: x => x.TreeTypeId,
                        principalSchema: "actrt",
                        principalTable: "AccountentTreeTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                schema: "emp",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountCode = table.Column<int>(type: "int", nullable: false),
                    PersonalId = table.Column<int>(type: "int", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NationalityId = table.Column<int>(type: "int", nullable: true),
                    Citizenship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JobPositionId = table.Column<int>(type: "int", nullable: true),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Countries_NationalityId",
                        column: x => x.NationalityId,
                        principalSchema: "cnt",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Employees_JobPositions_JobPositionId",
                        column: x => x.JobPositionId,
                        principalSchema: "jbp",
                        principalTable: "JobPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Organizations",
                schema: "org",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AuthenticationCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EN_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WebsiteURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrgTypeId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Organizations_OrganizationTypes_OrgTypeId",
                        column: x => x.OrgTypeId,
                        principalSchema: "orgt",
                        principalTable: "OrganizationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "prd",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Boxcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EN_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    TypeId = table.Column<int>(type: "int", nullable: true),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionCountryId = table.Column<int>(type: "int", nullable: true),
                    ManufacturerId = table.Column<int>(type: "int", nullable: true),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductionPrice = table.Column<float>(type: "real", nullable: false),
                    RetailPrice = table.Column<float>(type: "real", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalSchema: "bnd",
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Countries_ProductionCountryId",
                        column: x => x.ProductionCountryId,
                        principalSchema: "cnt",
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalSchema: "mfr",
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "prdc",
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_ProductTypes_TypeId",
                        column: x => x.TypeId,
                        principalSchema: "prdt",
                        principalTable: "ProductTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Warehouses",
                schema: "wrh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<int>(type: "int", nullable: false),
                    Account = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManagerId = table.Column<int>(type: "int", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Warehouses_Employees_ManagerId",
                        column: x => x.ManagerId,
                        principalSchema: "emp",
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AccountentTree_ParentTreeId",
                schema: "actr",
                table: "AccountentTree",
                column: "ParentTreeId");

            migrationBuilder.CreateIndex(
                name: "IX_AccountentTree_TreeTypeId",
                schema: "actr",
                table: "AccountentTree",
                column: "TreeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobPositionId",
                schema: "emp",
                table: "Employees",
                column: "JobPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NationalityId",
                schema: "emp",
                table: "Employees",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Organizations_OrgTypeId",
                schema: "org",
                table: "Organizations",
                column: "OrgTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                schema: "prd",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                schema: "prd",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturerId",
                schema: "prd",
                table: "Products",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductionCountryId",
                schema: "prd",
                table: "Products",
                column: "ProductionCountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeId",
                schema: "prd",
                table: "Products",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Warehouses_ManagerId",
                schema: "wrh",
                table: "Warehouses",
                column: "ManagerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountentTree",
                schema: "actr");

            migrationBuilder.DropTable(
                name: "Currencies",
                schema: "crc");

            migrationBuilder.DropTable(
                name: "Organizations",
                schema: "org");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "prd");

            migrationBuilder.DropTable(
                name: "Warehouses",
                schema: "wrh");

            migrationBuilder.DropTable(
                name: "AccountentTreeTypes",
                schema: "actrt");

            migrationBuilder.DropTable(
                name: "OrganizationTypes",
                schema: "orgt");

            migrationBuilder.DropTable(
                name: "Brands",
                schema: "bnd");

            migrationBuilder.DropTable(
                name: "Manufacturers",
                schema: "mfr");

            migrationBuilder.DropTable(
                name: "ProductCategories",
                schema: "prdc");

            migrationBuilder.DropTable(
                name: "ProductTypes",
                schema: "prdt");

            migrationBuilder.DropTable(
                name: "Employees",
                schema: "emp");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "cnt");

            migrationBuilder.DropTable(
                name: "JobPositions",
                schema: "jbp");
        }
    }
}
