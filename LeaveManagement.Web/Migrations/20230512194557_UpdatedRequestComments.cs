using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37faac37-e036-4ea7-b14a-fc1da0dc8748",
                column: "ConcurrencyStamp",
                value: "b497b63a-70ec-40ef-abdc-46db21efa779");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c4b63da8-e248-411b-a5fc-f568ae0aaa1",
                column: "ConcurrencyStamp",
                value: "f53397cf-42e5-4ef1-8385-08c2b11ccffe");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "40faac37-e036-4ea7-b14a-fc1da0dc8746",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59635910-41e7-4083-b202-c96e97b34a08", "AQAAAAEAACcQAAAAEDz7eLKheZgS1m9T7jemyPXETYJkS+HnYA6ok3JuhM4rxRXeqjCWeJVuk0BTOtb3hw==", "c63c1d03-e76f-4907-a674-f81ac13aa5ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2b63da8-e248-411b-a5fc-f568ae0ceee1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbd028a1-5215-46fe-b65a-06c6d87f903b", "AQAAAAEAACcQAAAAEBc2WqHSPW1O4pLQ9K5gjbMmBxDHNDpMsZUdxuIf1sDztggCv7IFmQFpOyJ7qOvoHg==", "d47840c6-b5e6-42fe-9a08-ea1833552f0f" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
