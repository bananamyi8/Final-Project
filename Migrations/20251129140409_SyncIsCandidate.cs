using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineVotingApplication.Migrations
{
    /// <inheritdoc />
    public partial class SyncIsCandidate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCandidate",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCandidate",
                table: "AspNetUsers");
        }
    }
}
