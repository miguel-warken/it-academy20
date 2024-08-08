using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02DemoConsoleSqlServer.Migrations
{
    public partial class AdicionadoComentarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComentariosS",
                columns: table => new
                {
                    ComentarioId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Conteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComentariosS", x => x.ComentarioId);
                    table.ForeignKey(
                        name: "FK_ComentariosS_Posts_PostId1",
                        column: x => x.PostId1,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComentariosS_PostId1",
                table: "ComentariosS",
                column: "PostId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComentariosS");
        }
    }
}
