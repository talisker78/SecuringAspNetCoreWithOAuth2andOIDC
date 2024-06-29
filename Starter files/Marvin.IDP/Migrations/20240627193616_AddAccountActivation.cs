using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Marvin.IDP.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountActivation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("135e19b9-4c63-48ea-95a3-8f51a4c231b0"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("28457157-5822-4f7b-a93b-3c52b0c518bc"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("4826acc1-3cbb-4778-adc5-699fb64220b0"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("8e2662d5-c4b9-4d3e-8b3f-26d763ec71c4"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b40b8964-67dc-4463-87ea-86ca1c64eafb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("b74f06f1-c417-4e56-bb15-8292a30a11bb"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("eb584fc6-b43f-419f-ac0d-e66dbf37f094"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("fb96f84e-db37-4dd7-af68-4fcdc9ee560d"));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SecurityCode",
                table: "Users",
                type: "TEXT",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "SecurityCodeExpirationDate",
                table: "Users",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("096b1607-747e-46eb-8633-52d3ffcdd095"), "40349312-d963-4f80-b7c0-b19c283efd7f", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" },
                    { new Guid("1020515b-91f3-4c4d-ac30-481a2ef97c8e"), "c6e1577f-8484-40cb-b809-7db1575cb808", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("139d3240-8fb6-4f6f-a20e-17896f03a874"), "aea9abd9-cd73-4802-bb3c-5630acb73ec7", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("73861394-62fb-42c2-a95a-582136aa2e43"), "19b0b3f7-6e5b-4789-bff3-b989df7c63b2", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("c07b1756-bee5-4166-a87f-e09b53522d02"), "402cbc91-0f01-4073-a0f0-1b0c05dff94f", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("c36aa4b0-27eb-46b2-a0f7-c2db67cf32ae"), "daf565cd-1f34-4457-8833-5b2018af00f9", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("c719e2ca-ded8-409c-85a2-f760cdc4b777"), "3187f58d-9e04-4884-9a76-1c4398e8ec8f", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("ff496d98-cc5e-4978-bb1e-8f3ea48844dd"), "e2bf69dc-090b-492c-973e-fa774b84ca0e", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "56d1b2db-8886-4b65-9be4-87db83b0a9f2", "david@someprider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                columns: new[] { "ConcurrencyStamp", "Email", "SecurityCode", "SecurityCodeExpirationDate" },
                values: new object[] { "a67844af-483a-429a-8f8c-0d4a629897e9", "emma@someprovider.com", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("096b1607-747e-46eb-8633-52d3ffcdd095"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("1020515b-91f3-4c4d-ac30-481a2ef97c8e"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("139d3240-8fb6-4f6f-a20e-17896f03a874"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("73861394-62fb-42c2-a95a-582136aa2e43"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c07b1756-bee5-4166-a87f-e09b53522d02"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c36aa4b0-27eb-46b2-a0f7-c2db67cf32ae"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("c719e2ca-ded8-409c-85a2-f760cdc4b777"));

            migrationBuilder.DeleteData(
                table: "UserClaims",
                keyColumn: "Id",
                keyValue: new Guid("ff496d98-cc5e-4978-bb1e-8f3ea48844dd"));

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "SecurityCodeExpirationDate",
                table: "Users");

            migrationBuilder.InsertData(
                table: "UserClaims",
                columns: new[] { "Id", "ConcurrencyStamp", "Type", "UserId", "Value" },
                values: new object[,]
                {
                    { new Guid("135e19b9-4c63-48ea-95a3-8f51a4c231b0"), "c314f0d7-31b8-4f21-a400-4ac8a0ddecd2", "role", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "PayingUser" },
                    { new Guid("28457157-5822-4f7b-a93b-3c52b0c518bc"), "e3c25016-362c-4ce4-911a-98488cbea10b", "given_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "David" },
                    { new Guid("4826acc1-3cbb-4778-adc5-699fb64220b0"), "0312fa67-9c57-47b1-9883-81ae0c147de5", "family_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Flagg" },
                    { new Guid("8e2662d5-c4b9-4d3e-8b3f-26d763ec71c4"), "979efd7c-61b5-42ff-9646-667e014a1cbf", "given_name", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "Emma" },
                    { new Guid("b40b8964-67dc-4463-87ea-86ca1c64eafb"), "8432a1ca-bab4-4cdb-ac81-1cf22bef3930", "family_name", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "Flagg" },
                    { new Guid("b74f06f1-c417-4e56-bb15-8292a30a11bb"), "d7e9b644-b4be-45e9-aa94-65ab3532d75f", "role", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "FreeUser" },
                    { new Guid("eb584fc6-b43f-419f-ac0d-e66dbf37f094"), "b51cac5a-64b1-4416-a317-927451d2ec6e", "country", new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"), "nl" },
                    { new Guid("fb96f84e-db37-4dd7-af68-4fcdc9ee560d"), "d88bedca-7b05-4251-91ca-77bb1aa4ec51", "country", new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"), "be" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("13229d33-99e0-41b3-b18d-4f72127e3971"),
                column: "ConcurrencyStamp",
                value: "53d68110-1526-4ad0-a4d3-f5be5e89b27c");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("96053525-f4a5-47ee-855e-0ea77fa6c55a"),
                column: "ConcurrencyStamp",
                value: "dedc916f-eda3-4ce3-87c3-ca4c0fa267bc");
        }
    }
}
