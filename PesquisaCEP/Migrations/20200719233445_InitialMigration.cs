using Microsoft.EntityFrameworkCore.Migrations;

namespace PesquisaCEP.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ends",
                columns: table => new
                {
                    EndId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cep = table.Column<string>(type: "varchar(50)", nullable: true),
                    Bairro = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    Logradouro = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    Localidade = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    Uf = table.Column<string>(type: "varchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ends", x => x.EndId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ends");
        }
    }
}
