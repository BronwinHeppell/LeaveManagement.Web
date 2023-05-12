using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37faac37-e036-4ea7-b14a-fc1da0dc8748",
                column: "ConcurrencyStamp",
                value: "6369681d-1daa-4977-9fae-0043cd7ab265");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4b63da8-e248-411b-a5fc-f568ae0aaa1",
                column: "ConcurrencyStamp",
                value: "fd0c34ae-d573-4082-89d5-1f792076a8a7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40faac37-e036-4ea7-b14a-fc1da0dc8746",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6600bbe-e617-4cb5-b74a-aca20d889585", "AQAAAAEAACcQAAAAENB4viXYLBjBdjG0fygxbRtrmAyutik2XX+jET9NFE52qD8dACsM1otnfhuX1LRPBw==", "cc8d8d74-34e9-471d-b175-516da3779598" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2b63da8-e248-411b-a5fc-f568ae0ceee1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5ecf956-c090-4639-a1dd-3124a269c9f0", "AQAAAAEAACcQAAAAEESypuHaOif+nNvUPn6wA2qwJjxo13aPpw3GjPy1QqfmLMV28D+cumrjg8SlDVStSw==", "755e3663-ddde-4485-b2ef-ae91744d4724" });

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37faac37-e036-4ea7-b14a-fc1da0dc8748",
                column: "ConcurrencyStamp",
                value: "9a34ba72-a258-4b0b-b6da-792c868efa6f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4b63da8-e248-411b-a5fc-f568ae0aaa1",
                column: "ConcurrencyStamp",
                value: "7bdf5c4c-e7eb-44d8-ae1a-7eb812911da4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40faac37-e036-4ea7-b14a-fc1da0dc8746",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb80bf18-260c-4a67-bec2-1be390955494", "AQAAAAEAACcQAAAAEInLqmOInI5S8T5HhjbeDyFwEvhWRj/o1mmBSCJcbr7Eu3IS03CGaO0u7DhmhZD9wQ==", "61a77059-b810-498d-ab18-62c0466f98b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2b63da8-e248-411b-a5fc-f568ae0ceee1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "60033aeb-4792-4d76-af35-c9c1fb7499ae", "AQAAAAEAACcQAAAAEBNXJEvR1QLLdPF41tyJPn2U7tx0DnG0hJe4XWK1gnV7TlML0GOlyZst6yVYfoVatg==", "bb20c942-cfed-4a0b-8528-a42e0433297e" });
        }
    }
}
