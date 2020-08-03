using Microsoft.EntityFrameworkCore.Migrations;

namespace JobsPortal.DBContext.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "JobPostings",
                columns: table => new
                {
                    JobPostingID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Experience = table.Column<string>(nullable: true),
                    JobRole = table.Column<string>(nullable: true),
                    JobDescription = table.Column<string>(nullable: true),
                    ContactEmailId = table.Column<string>(nullable: true),
                    ContactPhoneNo = table.Column<string>(nullable: true),
                    EmploymentType = table.Column<string>(nullable: true),
                    IndustryType = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Skills = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobPostings", x => x.JobPostingID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobPostings");
        }
    }
}
