using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArjSys.Migrations
{
    /// <inheritdoc />
    public partial class AddRefactorModelProjeto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataFim",
                table: "Projetos",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataFim",
                table: "Projetos");
        }
    }
}
