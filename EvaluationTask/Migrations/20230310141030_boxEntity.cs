using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluationTask.Migrations
{
    /// <inheritdoc />
    public partial class boxEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "box",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fromDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    toDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    noEnvelope = table.Column<int>(type: "int", nullable: false),
                    shipmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_box", x => x.id);
                    table.ForeignKey(
                        name: "FK_box_Shipment_shipmentId",
                        column: x => x.shipmentId,
                        principalTable: "Shipment",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_box_shipmentId",
                table: "box",
                column: "shipmentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "box");
        }
    }
}
