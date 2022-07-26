using Microsoft.EntityFrameworkCore.Migrations;

namespace DnDLetItRoll.Data.Migrations
{
    public partial class FirstSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Races",
                columns: new[] { "Id", "Description", "IncreaseAmount", "Languages", "Name", "RacialTraits", "Size", "Speed", "StatIncreased" },
                values: new object[] { 1, "Bold and Hardy, Dwarves are known as skilled warriors, miners, and workers of stone and metal.", 2, "[\"Common\",\"Dwarvish\"]", "Dwarf", "[\"Darkvision\",\"Dwarven Resilience\",\"Dwarven Combat Training\",\"Stonecunning\"]", "Medium", 25, "Constitution" });

            migrationBuilder.InsertData(
                table: "Subraces",
                columns: new[] { "Id", "Description", "IncreaseAmount", "Name", "RaceId", "RacialTraits", "StatIncreased" },
                values: new object[] { 1, "As a hill dwarf, you have keen senses, deep intuition, and remarkable resilience.", 1, "Hill Dwarf", 1, "[\"Dwarven Toughness\"]", "Wisdom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Subraces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Races",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
