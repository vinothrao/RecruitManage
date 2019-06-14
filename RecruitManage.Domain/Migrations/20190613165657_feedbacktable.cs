using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitManage.Domain.Migrations
{
    public partial class feedbacktable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InterviewFeedbacks",
                columns: table => new
                {
                    InterviewFeedbackId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScheduleId = table.Column<int>(nullable: false),
                    IsSelected = table.Column<bool>(nullable: false),
                    Feedback = table.Column<string>(nullable: true),
                    FeedbackSentToCandidate = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewFeedbacks", x => x.InterviewFeedbackId);
                    table.ForeignKey(
                        name: "FK_InterviewFeedbacks_InterviewSchedule_ScheduleId",
                        column: x => x.ScheduleId,
                        principalTable: "InterviewSchedule",
                        principalColumn: "InterviewScheduleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InterviewFeedbacks_ScheduleId",
                table: "InterviewFeedbacks",
                column: "ScheduleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InterviewFeedbacks");
        }
    }
}
