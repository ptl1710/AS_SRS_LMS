using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AS_SRS_LMS.Migrations
{
    public partial class fixdb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_Subjects_SubjectId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_Documents_Subjects_SubjectId",
                table: "Documents");

            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Subjects_SubjectId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Exams_ExamId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Results_Users_UserId",
                table: "Results");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedules_Subjects_SubjectId",
                table: "Schedules");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Subjects_SubjectId",
                table: "Test");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Users_UserId",
                table: "Test");

            migrationBuilder.DropForeignKey(
                name: "FK_TypeExams_Test_TestId",
                table: "TypeExams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypeExams",
                table: "TypeExams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Results",
                table: "Results");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exams",
                table: "Exams");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Documents",
                table: "Documents");

            migrationBuilder.RenameTable(
                name: "TypeExams",
                newName: "ContentTest");

            migrationBuilder.RenameTable(
                name: "Subjects",
                newName: "Subject");

            migrationBuilder.RenameTable(
                name: "Schedules",
                newName: "Schedule");

            migrationBuilder.RenameTable(
                name: "Results",
                newName: "ResultExam");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "Exams",
                newName: "Exam");

            migrationBuilder.RenameTable(
                name: "Documents",
                newName: "Document");

            migrationBuilder.RenameIndex(
                name: "IX_TypeExams_TestId",
                table: "ContentTest",
                newName: "IX_ContentTest_TestId");

            migrationBuilder.RenameIndex(
                name: "IX_Schedules_SubjectId",
                table: "Schedule",
                newName: "IX_Schedule_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Results_UserId",
                table: "ResultExam",
                newName: "IX_ResultExam_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Results_ExamId",
                table: "ResultExam",
                newName: "IX_ResultExam_ExamId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_SubjectId",
                table: "Question",
                newName: "IX_Question_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Exams_SubjectId",
                table: "Exam",
                newName: "IX_Exam_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Documents_SubjectId",
                table: "Document",
                newName: "IX_Document_SubjectId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Test",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "TestScheduleId",
                table: "Exam",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ContentTest",
                table: "ContentTest",
                column: "ContentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subject",
                table: "Subject",
                column: "SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule",
                column: "ScheduleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ResultExam",
                table: "ResultExam",
                column: "ResultId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exam",
                table: "Exam",
                column: "ExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Document",
                table: "Document",
                column: "DocumentId");

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    AnswerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RightWrong = table.Column<bool>(type: "bit", nullable: false),
                    IdExam = table.Column<int>(type: "int", nullable: false),
                    ExamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.AnswerId);
                    table.ForeignKey(
                        name: "FK_Answer_Exam_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exam",
                        principalColumn: "ExamId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ResultLearning",
                columns: table => new
                {
                    LRId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ScoreAvg = table.Column<float>(type: "real", nullable: false),
                    AttendancePoint = table.Column<float>(type: "real", nullable: false),
                    ScoreOralTest = table.Column<float>(type: "real", nullable: false),
                    Score = table.Column<float>(type: "real", nullable: false),
                    Score15Minunes = table.Column<float>(type: "real", nullable: false),
                    ScoreCoefficient2 = table.Column<float>(type: "real", nullable: false),
                    ScoreCoefficient3 = table.Column<float>(type: "real", nullable: false),
                    SumScoreAvg = table.Column<float>(type: "real", nullable: false),
                    ResultOfEvaluation = table.Column<bool>(type: "bit", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdSubject = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    IdUser = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultLearning", x => x.LRId);
                    table.ForeignKey(
                        name: "FK_ResultLearning_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "SubjectId");
                    table.ForeignKey(
                        name: "FK_ResultLearning_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId");
                });

            migrationBuilder.CreateTable(
                name: "TestSchedule",
                columns: table => new
                {
                    TestScheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayExam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TestSchedule", x => x.TestScheduleId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exam_TestScheduleId",
                table: "Exam",
                column: "TestScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Answer_ExamId",
                table: "Answer",
                column: "ExamId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultLearning_SubjectId",
                table: "ResultLearning",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultLearning_UserId",
                table: "ResultLearning",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Subject_SubjectId",
                table: "Class",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ContentTest_Test_TestId",
                table: "ContentTest",
                column: "TestId",
                principalTable: "Test",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Document_Subject_SubjectId",
                table: "Document",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_Subject_SubjectId",
                table: "Exam",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exam_TestSchedule_TestScheduleId",
                table: "Exam",
                column: "TestScheduleId",
                principalTable: "TestSchedule",
                principalColumn: "TestScheduleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Subject_SubjectId",
                table: "Question",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_ResultExam_Exam_ExamId",
                table: "ResultExam",
                column: "ExamId",
                principalTable: "Exam",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ResultExam_Users_UserId",
                table: "ResultExam",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedule_Subject_SubjectId",
                table: "Schedule",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Subject_SubjectId",
                table: "Test",
                column: "SubjectId",
                principalTable: "Subject",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Users_UserId",
                table: "Test",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_Subject_SubjectId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_ContentTest_Test_TestId",
                table: "ContentTest");

            migrationBuilder.DropForeignKey(
                name: "FK_Document_Subject_SubjectId",
                table: "Document");

            migrationBuilder.DropForeignKey(
                name: "FK_Exam_Subject_SubjectId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_Exam_TestSchedule_TestScheduleId",
                table: "Exam");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Subject_SubjectId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_ResultExam_Exam_ExamId",
                table: "ResultExam");

            migrationBuilder.DropForeignKey(
                name: "FK_ResultExam_Users_UserId",
                table: "ResultExam");

            migrationBuilder.DropForeignKey(
                name: "FK_Schedule_Subject_SubjectId",
                table: "Schedule");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Subject_SubjectId",
                table: "Test");

            migrationBuilder.DropForeignKey(
                name: "FK_Test_Users_UserId",
                table: "Test");

            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "ResultLearning");

            migrationBuilder.DropTable(
                name: "TestSchedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Subject",
                table: "Subject");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Schedule",
                table: "Schedule");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ResultExam",
                table: "ResultExam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Exam",
                table: "Exam");

            migrationBuilder.DropIndex(
                name: "IX_Exam_TestScheduleId",
                table: "Exam");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Document",
                table: "Document");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ContentTest",
                table: "ContentTest");

            migrationBuilder.DropColumn(
                name: "TestScheduleId",
                table: "Exam");

            migrationBuilder.RenameTable(
                name: "Subject",
                newName: "Subjects");

            migrationBuilder.RenameTable(
                name: "Schedule",
                newName: "Schedules");

            migrationBuilder.RenameTable(
                name: "ResultExam",
                newName: "Results");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "Exam",
                newName: "Exams");

            migrationBuilder.RenameTable(
                name: "Document",
                newName: "Documents");

            migrationBuilder.RenameTable(
                name: "ContentTest",
                newName: "TypeExams");

            migrationBuilder.RenameIndex(
                name: "IX_Schedule_SubjectId",
                table: "Schedules",
                newName: "IX_Schedules_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ResultExam_UserId",
                table: "Results",
                newName: "IX_Results_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_ResultExam_ExamId",
                table: "Results",
                newName: "IX_Results_ExamId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_SubjectId",
                table: "Questions",
                newName: "IX_Questions_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Exam_SubjectId",
                table: "Exams",
                newName: "IX_Exams_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_Document_SubjectId",
                table: "Documents",
                newName: "IX_Documents_SubjectId");

            migrationBuilder.RenameIndex(
                name: "IX_ContentTest_TestId",
                table: "TypeExams",
                newName: "IX_TypeExams_TestId");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Test",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Subjects",
                table: "Subjects",
                column: "SubjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Schedules",
                table: "Schedules",
                column: "ScheduleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Results",
                table: "Results",
                column: "ResultId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "QuestionId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Exams",
                table: "Exams",
                column: "ExamId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Documents",
                table: "Documents",
                column: "DocumentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypeExams",
                table: "TypeExams",
                column: "ContentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Subjects_SubjectId",
                table: "Class",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_Subjects_SubjectId",
                table: "Documents",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Subjects_SubjectId",
                table: "Exams",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Subjects_SubjectId",
                table: "Questions",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Exams_ExamId",
                table: "Results",
                column: "ExamId",
                principalTable: "Exams",
                principalColumn: "ExamId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Users_UserId",
                table: "Results",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Schedules_Subjects_SubjectId",
                table: "Schedules",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Subjects_SubjectId",
                table: "Test",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "SubjectId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Test_Users_UserId",
                table: "Test",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypeExams_Test_TestId",
                table: "TypeExams",
                column: "TestId",
                principalTable: "Test",
                principalColumn: "TestId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
