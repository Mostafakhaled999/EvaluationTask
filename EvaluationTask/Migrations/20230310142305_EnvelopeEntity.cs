using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EvaluationTask.Migrations
{
    /// <inheritdoc />
    public partial class EnvelopeEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_box_Shipment_shipmentId",
                table: "box");

            migrationBuilder.DropPrimaryKey(
                name: "PK_box",
                table: "box");

            migrationBuilder.RenameTable(
                name: "box",
                newName: "Box");

            migrationBuilder.RenameIndex(
                name: "IX_box_shipmentId",
                table: "Box",
                newName: "IX_Box_shipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Box",
                table: "Box",
                column: "id");

            migrationBuilder.CreateTable(
                name: "Envelope",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    code = table.Column<int>(type: "int", nullable: false),
                    nobatches = table.Column<int>(type: "int", nullable: false),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    boxId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Envelope", x => x.id);
                    table.ForeignKey(
                        name: "FK_Envelope_Box_boxId",
                        column: x => x.boxId,
                        principalTable: "Box",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Envelope_boxId",
                table: "Envelope",
                column: "boxId");

            migrationBuilder.AddForeignKey(
                name: "FK_Box_Shipment_shipmentId",
                table: "Box",
                column: "shipmentId",
                principalTable: "Shipment",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Box_Shipment_shipmentId",
                table: "Box");

            migrationBuilder.DropTable(
                name: "Envelope");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Box",
                table: "Box");

            migrationBuilder.RenameTable(
                name: "Box",
                newName: "box");

            migrationBuilder.RenameIndex(
                name: "IX_Box_shipmentId",
                table: "box",
                newName: "IX_box_shipmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_box",
                table: "box",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_box_Shipment_shipmentId",
                table: "box",
                column: "shipmentId",
                principalTable: "Shipment",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
