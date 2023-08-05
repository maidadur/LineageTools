using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LineageTools.Experience.DB.Migrations
{
    /// <inheritdoc />
    public partial class ExpCountTypeFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "ExpCount",
                table: "ExperienceToLevel",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ExpCount",
                table: "ExperienceToLevel",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
