using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDLetItRoll.Data.Migrations
{
    public partial class SeedDataII : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Backgrounds",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "War has been your life for as long as you care to remember. You trained as a youth, studied the use of weapons and armor, learned basic survival techniques, including how to stay alive on the battlefield. You might have been part of a standing national army or a mercenary company, or perhaps a member of a local militia who rose to prominence during a recent war.", "Soldier" });

            migrationBuilder.InsertData(
                table: "Classes",
                columns: new[] { "Id", "Description", "HitDie", "Name" },
                values: new object[] { 1, "A fierce warrior of primitive background who can enter a battle rage.", "d12", "Barbarian" });

            migrationBuilder.InsertData(
                table: "Subraces",
                columns: new[] { "Id", "Description", "IncreaseAmount", "Name", "RaceId", "RacialTraits", "StatIncreased" },
                values: new object[] { 2, "As a mountian dwarf, you're strong and hardy, accustomed to a difficult life in rugged terrain. You're probably on teh tall side (for a dwarf), and tend toward lighter coloration.", 2, "Mountain Dwarf", 1, "[\"Dwarven Armor Training\"]", "Strength" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Backgrounds",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Classes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Subraces",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
