using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shaheen.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trade",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    TradeName = table.Column<string>(maxLength: 250, nullable: false),
                    ManufactureCompany = table.Column<string>(maxLength: 250, nullable: true),
                    AdditionalInfo = table.Column<string>(maxLength: 250, nullable: false),
                    TestCertificateIssuer = table.Column<string>(maxLength: 250, nullable: false),
                    TestReportNumber = table.Column<string>(maxLength: 250, nullable: false),
                    TestCertificateNumber = table.Column<string>(maxLength: 250, nullable: false),
                    SupplierCommercialRegistry = table.Column<string>(maxLength: 250, nullable: false),
                    SupplierName = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TradeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OriginCountry = table.Column<string>(maxLength: 250, nullable: false),
                    Make = table.Column<string>(maxLength: 250, nullable: false),
                    Condition = table.Column<string>(maxLength: 250, nullable: false),
                    TradeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TradeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TradeDetails_Trade_TradeId",
                        column: x => x.TradeId,
                        principalTable: "Trade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TradeDetails_TradeId",
                table: "TradeDetails",
                column: "TradeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TradeDetails");

            migrationBuilder.DropTable(
                name: "Trade");
        }
    }
}
