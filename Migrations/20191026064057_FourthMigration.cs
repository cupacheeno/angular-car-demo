using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_MakeId",
                table: "Motorbikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Makers",
                table: "Makers");

            migrationBuilder.DropIndex(
                name: "IX_Cars_MakeId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Makers");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "Cars");

            migrationBuilder.AddColumn<Guid>(
                name: "MakerId",
                table: "Motorbikes",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModelId",
                table: "Models",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MakerId",
                table: "Makers",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MakerId",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "ModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Makers",
                table: "Makers",
                column: "MakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_MakerId",
                table: "Motorbikes",
                column: "MakerId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_MakerId",
                table: "Cars",
                column: "MakerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Makers_MakerId",
                table: "Cars",
                column: "MakerId",
                principalTable: "Makers",
                principalColumn: "MakerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Models_ModelId",
                table: "Cars",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Makers_MakerId",
                table: "Models",
                column: "MakerId",
                principalTable: "Makers",
                principalColumn: "MakerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Makers_MakerId",
                table: "Motorbikes",
                column: "MakerId",
                principalTable: "Makers",
                principalColumn: "MakerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Motorbikes_Models_ModelId",
                table: "Motorbikes",
                column: "ModelId",
                principalTable: "Models",
                principalColumn: "ModelId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Makers_MakerId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Models_ModelId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Makers_MakerId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Makers_MakerId",
                table: "Motorbikes");

            migrationBuilder.DropForeignKey(
                name: "FK_Motorbikes_Models_ModelId",
                table: "Motorbikes");

            migrationBuilder.DropIndex(
                name: "IX_Motorbikes_MakerId",
                table: "Motorbikes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Models",
                table: "Models");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Makers",
                table: "Makers");

            migrationBuilder.DropIndex(
                name: "IX_Cars_MakerId",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "MakerId",
                table: "Motorbikes");

            migrationBuilder.DropColumn(
                name: "ModelId",
                table: "Models");

            migrationBuilder.DropColumn(
                name: "MakerId",
                table: "Makers");

            migrationBuilder.DropColumn(
                name: "MakerId",
                table: "Cars");

            migrationBuilder.AddColumn<Guid>(
                name: "MakeId",
                table: "Motorbikes",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Models",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Makers",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MakeId",
                table: "Cars",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Models",
                table: "Models",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Makers",
                table: "Makers",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Motorbikes_MakeId",
                table: "Motorbikes",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_MakeId",
                table: "Cars",
                column: "MakeId");

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
    }
}
