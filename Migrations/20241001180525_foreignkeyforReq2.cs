using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SCM.Migrations
{
    /// <inheritdoc />
    public partial class foreignkeyforReq2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequisitionDetail_RequisitionMaster_RequisitionMasterRequisitionID",
                table: "RequisitionDetail");

            migrationBuilder.DropIndex(
                name: "IX_RequisitionDetail_RequisitionMasterRequisitionID",
                table: "RequisitionDetail");

            migrationBuilder.DropColumn(
                name: "RequisitionMasterRequisitionID",
                table: "RequisitionDetail");

            migrationBuilder.CreateIndex(
                name: "IX_RequisitionDetail_RequisitionID",
                table: "RequisitionDetail",
                column: "RequisitionID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequisitionDetail_RequisitionMaster_RequisitionID",
                table: "RequisitionDetail",
                column: "RequisitionID",
                principalTable: "RequisitionMaster",
                principalColumn: "RequisitionID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RequisitionDetail_RequisitionMaster_RequisitionID",
                table: "RequisitionDetail");

            migrationBuilder.DropIndex(
                name: "IX_RequisitionDetail_RequisitionID",
                table: "RequisitionDetail");

            migrationBuilder.AddColumn<int>(
                name: "RequisitionMasterRequisitionID",
                table: "RequisitionDetail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RequisitionDetail_RequisitionMasterRequisitionID",
                table: "RequisitionDetail",
                column: "RequisitionMasterRequisitionID");

            migrationBuilder.AddForeignKey(
                name: "FK_RequisitionDetail_RequisitionMaster_RequisitionMasterRequisitionID",
                table: "RequisitionDetail",
                column: "RequisitionMasterRequisitionID",
                principalTable: "RequisitionMaster",
                principalColumn: "RequisitionID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
