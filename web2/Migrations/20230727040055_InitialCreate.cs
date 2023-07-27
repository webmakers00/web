using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace web2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ord",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ordid = table.Column<int>(type: "INTEGER", nullable: false),
                    cusna = table.Column<string>(type: "TEXT", nullable: true),
                    cusid = table.Column<int>(type: "INTEGER", nullable: false),
                    n = table.Column<int>(type: "INTEGER", nullable: false),
                    dstar = table.Column<int>(type: "INTEGER", nullable: false),
                    dend = table.Column<int>(type: "INTEGER", nullable: false),
                    first = table.Column<int>(type: "INTEGER", nullable: false),
                    des = table.Column<string>(type: "TEXT", nullable: true),
                    isdel = table.Column<int>(type: "INTEGER", nullable: false),
                    isend = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "step",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    isstar = table.Column<bool>(type: "INTEGER", nullable: false),
                    isend = table.Column<bool>(type: "INTEGER", nullable: false),
                    dstar = table.Column<int>(type: "INTEGER", nullable: false),
                    dend = table.Column<int>(type: "INTEGER", nullable: false),
                    month = table.Column<int>(type: "INTEGER", nullable: false),
                    ordId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_step", x => x.Id);
                    table.ForeignKey(
                        name: "FK_step_ord_ordId",
                        column: x => x.ordId,
                        principalTable: "ord",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "boy",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    n = table.Column<int>(type: "INTEGER", nullable: false),
                    allmoney = table.Column<int>(type: "INTEGER", nullable: false),
                    stepId = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_boy", x => x.Id);
                    table.ForeignKey(
                        name: "FK_boy_step_stepId",
                        column: x => x.stepId,
                        principalTable: "step",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_boy_stepId",
                table: "boy",
                column: "stepId");

            migrationBuilder.CreateIndex(
                name: "IX_step_ordId",
                table: "step",
                column: "ordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "boy");

            migrationBuilder.DropTable(
                name: "step");

            migrationBuilder.DropTable(
                name: "ord");
        }
    }
}
