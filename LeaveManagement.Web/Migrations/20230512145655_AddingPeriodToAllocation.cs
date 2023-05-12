using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37faac37-e036-4ea7-b14a-fc1da0dc8748",
                column: "ConcurrencyStamp",
                value: "d1e219f3-eb16-4059-9b29-0c38d8c4aeb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4b63da8-e248-411b-a5fc-f568ae0aaa1",
                column: "ConcurrencyStamp",
                value: "d3afdb51-48a1-41e2-beb7-dc0fdd40f95d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40faac37-e036-4ea7-b14a-fc1da0dc8746",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9db9a4c-008c-4bde-b29d-2829741a7758", "AQAAAAEAACcQAAAAEMrAjc/tKXGdAbPJrg7r+FPcWz+PHaUK9y5/5BVl+mtsXDMHVFsYmQQHai32GUkFAQ==", "47bb6ca1-d561-4b3f-a7d4-d027bdb358d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2b63da8-e248-411b-a5fc-f568ae0ceee1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "191f08d6-0098-4e3d-a367-d991ce6cfe1e", "AQAAAAEAACcQAAAAEJht3E7WEbsB/2+RcJEFrkJqMI5COCadx0bLrc9zBSpGenfkeFhEwpkmpo8V2GvZOA==", "55e52edf-9d27-415b-b7b3-a8b51aefb09e" });
        }
    }
}
