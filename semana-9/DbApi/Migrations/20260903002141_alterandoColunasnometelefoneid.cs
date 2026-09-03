using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DbApi.Migrations
{
    /// <inheritdoc />
    public partial class alterandoColunasnometelefoneid : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Clientes",
                newName: "nomeCli");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clientes",
                newName: "codCli");

            migrationBuilder.AlterColumn<string>(
                name: "nomeCli",
                table: "Clientes",
                type: "varchar(150)",
                maxLength: 150,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "nomeCli",
                table: "Clientes",
                newName: "Nome");

            migrationBuilder.RenameColumn(
                name: "codCli",
                table: "Clientes",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(150)",
                oldMaxLength: 150);
        }
    }
}
