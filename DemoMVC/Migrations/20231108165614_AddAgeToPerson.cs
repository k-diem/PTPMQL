using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMVC.Migrations
{
    /// <inheritdoc />
    public partial class AddAgeToPerson : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Fullname",
                table: "Persons",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Persons",
                newName: "PersonId");

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Persons",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Persons");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Persons",
                newName: "Fullname");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Persons",
                newName: "PersonID");
        }
    }
}
