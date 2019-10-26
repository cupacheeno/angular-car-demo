using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class ThirdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Maker_MakeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Model_ModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Model_Maker_MakerId",
                table: "Model");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Maker_MakeId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Model_ModelId",
                table: "Motorbikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Model",
                table: "Model");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Maker",
                table: "Maker");

            migrationBuilder.RenameTable(
                name: "Model",
                newName: "Models");

            migrationBuilder.RenameTable(
                name: "Maker",
                newName: "Makers");

            migrationBuilder.RenameIndex(
                name: "IX_Model_MakerId",
                table: "Models",
                newName: "IX_Models_MakerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Makers",
                table: "Makers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Makers_MakeId",
                table: "Cars",
                column: "MakeId",
                principalTable: "Makers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Models_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makers_MakerId",
                table: "Models",
                column: "MakerId",
                principalTable: "Makers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Makers_MakeId",
                table: "Motorbikes",
                column: "MakeId",
                principalTable: "Makers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Models_ModelId",
                table: "Motorbikes",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Makers_MakeId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Models_ModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makers_MakerId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Makers_MakeId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Models_ModelId",
                table: "Motorbikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Makers",
                table: "Makers");

            migrationBuilder.RenameTable(
                name: "Models",
                newName: "Model");

            migrationBuilder.RenameTable(
                name: "Makers",
                newName: "Maker");

            migrationBuilder.RenameIndex(
                name: "IX_Models_MakerId",
                table: "Model",
                newName: "IX_Model_MakerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Model",
                table: "Model",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Maker",
                table: "Maker",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Maker_MakeId",
                table: "Cars",
                column: "MakeId",
                principalTable: "Maker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Model_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Model_Maker_MakerId",
                table: "Model",
                column: "MakerId",
                principalTable: "Maker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Maker_MakeId",
                table: "Motorbikes",
                column: "MakeId",
                principalTable: "Maker",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Model_ModelId",
                table: "Motorbikes",
                column: "ModelId",
                principalTable: "Model",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
