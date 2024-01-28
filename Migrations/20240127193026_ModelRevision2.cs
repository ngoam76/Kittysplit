using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kittysplit.Migrations
{
    public partial class ModelRevision2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExpenseParticipant",
                columns: table => new
                {
                    ExpensesExpenseId = table.Column<int>(type: "INTEGER", nullable: false),
                    ParticipantsParticipantId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExpenseParticipant", x => new { x.ExpensesExpenseId, x.ParticipantsParticipantId });
                    table.ForeignKey(
                        name: "FK_ExpenseParticipant_Expenses_ExpensesExpenseId",
                        column: x => x.ExpensesExpenseId,
                        principalTable: "Expenses",
                        principalColumn: "ExpenseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ExpenseParticipant_Participants_ParticipantsParticipantId",
                        column: x => x.ParticipantsParticipantId,
                        principalTable: "Participants",
                        principalColumn: "ParticipantId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ExpenseParticipant_ParticipantsParticipantId",
                table: "ExpenseParticipant",
                column: "ParticipantsParticipantId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExpenseParticipant");
        }
    }
}
