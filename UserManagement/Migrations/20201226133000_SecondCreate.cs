using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserFirstName = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    UserLastName = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    UserEmail = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    UserPhone = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    UserAddress = table.Column<string>(type: "nvarchar(250)", nullable: true),
                    UserGender = table.Column<string>(type: "nvarchar(40)", nullable: true),
                    UserActive = table.Column<string>(type: "nvarchar(40)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserDetailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
