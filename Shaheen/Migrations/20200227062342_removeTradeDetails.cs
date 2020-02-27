using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shaheen.Migrations
{
    public partial class removeTradeDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TradeDetails");

            migrationBuilder.AddColumn<string>(
                name: "Condition",
                table: "Trade",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Make",
                table: "Trade",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OriginCountry",
                table: "Trade",
                maxLength: 250,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Condition",
                table: "Trade");

            migrationBuilder.DropColumn(
                name: "Make",
                table: "Trade");

            migrationBuilder.DropColumn(
                name: "OriginCountry",
                table: "Trade");

            migrationBuilder.CreateTable(
                name: "TradeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Condition = table.Column<string>(maxLength: 250, nullable: false),
                    Make = table.Column<string>(maxLength: 250, nullable: false),
                    OriginCountry = table.Column<string>(maxLength: 250, nullable: false),
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
    }
}
