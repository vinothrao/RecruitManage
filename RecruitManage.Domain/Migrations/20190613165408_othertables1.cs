using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecruitManage.Domain.Migrations
{
    public partial class othertables1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    CandidateId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CandidateName = table.Column<string>(nullable: true),
                    CurrentCompanyName = table.Column<string>(nullable: true),
                    YearsOfExperience = table.Column<decimal>(nullable: false),
                    NoticePeriodInDays = table.Column<int>(nullable: false),
                    InNoticePeriod = table.Column<bool>(nullable: false),
                    LastWorkingDay = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.CandidateId);
                });

            migrationBuilder.CreateTable(
                name: "CandidateTechnologyMappings",
                columns: table => new
                {
                    CandidateTechnologyMappingId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CanditateId = table.Column<int>(nullable: false),
                    TechnologyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CandidateTechnologyMappings", x => x.CandidateTechnologyMappingId);
                    table.ForeignKey(
                        name: "FK_CandidateTechnologyMappings_Candidates_CanditateId",
                        column: x => x.CanditateId,
                        principalTable: "Candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CandidateTechnologyMappings_Technologies_TechnologyId",
                        column: x => x.TechnologyId,
                        principalTable: "Technologies",
                        principalColumn: "TechnologyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterviewSchedule",
                columns: table => new
                {
                    InterviewScheduleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScheduleName = table.Column<string>(nullable: true),
                    ScheduledDateTime = table.Column<DateTime>(nullable: false),
                    IsFeedbackRecieved = table.Column<bool>(nullable: false),
                    SentMailToCandidate = table.Column<bool>(nullable: false),
                    SentMailToInterviewer = table.Column<bool>(nullable: false),
                    Round = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    CandidateId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewSchedule", x => x.InterviewScheduleId);
                    table.ForeignKey(
                        name: "FK_InterviewSchedule_Candidates_CandidateId",
                        column: x => x.CandidateId,
                        principalTable: "Candidates",
                        principalColumn: "CandidateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterviewSchedule_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CandidateTechnologyMappings_CanditateId",
                table: "CandidateTechnologyMappings",
                column: "CanditateId");

            migrationBuilder.CreateIndex(
                name: "IX_CandidateTechnologyMappings_TechnologyId",
                table: "CandidateTechnologyMappings",
                column: "TechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewSchedule_CandidateId",
                table: "InterviewSchedule",
                column: "CandidateId");

            migrationBuilder.CreateIndex(
                name: "IX_InterviewSchedule_UserId",
                table: "InterviewSchedule",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CandidateTechnologyMappings");

            migrationBuilder.DropTable(
                name: "InterviewSchedule");

            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
