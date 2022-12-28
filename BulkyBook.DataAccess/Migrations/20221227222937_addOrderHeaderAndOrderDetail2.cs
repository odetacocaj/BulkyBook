﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBookWeb.Migrations
{
    public partial class addOrderHeaderAndOrderDetail2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_OrderHeader_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderHeader_AspNetUsers_ApplicationUserId",
                table: "OrderHeader");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderHeader",
                table: "OrderHeader");

            migrationBuilder.RenameTable(
                name: "OrderHeader",
                newName: "OrderHeaders");

            migrationBuilder.RenameIndex(
                name: "IX_OrderHeader_ApplicationUserId",
                table: "OrderHeaders",
                newName: "IX_OrderHeaders_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderHeaders",
                table: "OrderHeaders",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_OrderHeaders_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "OrderHeaders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                table: "OrderHeaders",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetail_OrderHeaders_OrderId",
                table: "OrderDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderHeaders_AspNetUsers_ApplicationUserId",
                table: "OrderHeaders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderHeaders",
                table: "OrderHeaders");

            migrationBuilder.RenameTable(
                name: "OrderHeaders",
                newName: "OrderHeader");

            migrationBuilder.RenameIndex(
                name: "IX_OrderHeaders_ApplicationUserId",
                table: "OrderHeader",
                newName: "IX_OrderHeader_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderHeader",
                table: "OrderHeader",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetail_OrderHeader_OrderId",
                table: "OrderDetail",
                column: "OrderId",
                principalTable: "OrderHeader",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderHeader_AspNetUsers_ApplicationUserId",
                table: "OrderHeader",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
