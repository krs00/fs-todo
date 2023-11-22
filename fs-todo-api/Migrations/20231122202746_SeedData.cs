using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fs_todo_api.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "ToDoId", "Completed", "Description", "Title" },
                values: new object[] { 1, false, "wash all the dishes in the sink!", "Wash Dishes" });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "ToDoId", "Completed", "Description", "Title" },
                values: new object[] { 2, false, "clean the bathroom!", "Clean bathroom" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ToDos",
                keyColumn: "ToDoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ToDos",
                keyColumn: "ToDoId",
                keyValue: 2);
        }
    }
}
