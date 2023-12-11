using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CtlWebApp.DAL.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalCode = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    IdentityNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", unicode: false, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", maxLength: 40, nullable: false),
                    BirthPlace = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    PhoneNumber = table.Column<int>(type: "int", maxLength: 11, nullable: false),
                    NameOfFather = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Gender = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    MartialStatus = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    DateOfDispatch = table.Column<DateTime>(type: "datetime2", maxLength: 40, nullable: false),
                    VazifeState = table.Column<int>(type: "int", nullable: false),
                    Releasedate = table.Column<DateTime>(type: "datetime2", maxLength: 40, nullable: false),
                    Acceptenc = table.Column<bool>(type: "bit", maxLength: 5, nullable: false),
                    Skill = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    VerficationCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Avenue = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Street = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Number = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    TotalAverage = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    DateReceived = table.Column<DateTime>(type: "datetime2", maxLength: 40, nullable: false),
                    Orientaion = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FeildOfStudy = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Educatuion = table.Column<int>(type: "int", maxLength: 30, nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Educations_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkHistory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkPlaceName = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: true),
                    Jobtittle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", maxLength: 40, nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", maxLength: 40, nullable: false),
                    LastRight = table.Column<long>(type: "bigint", maxLength: 50, nullable: false),
                    ReasonForLeavingServeices = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    PersonId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkHistory_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Citys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Citys_States_StateId",
                        column: x => x.StateId,
                        principalTable: "States",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Citys_StateId",
                table: "Citys",
                column: "StateId");

            migrationBuilder.CreateIndex(
                name: "IX_Educations_PersonId",
                table: "Educations",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkHistory_PersonId",
                table: "WorkHistory",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Citys");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "WorkHistory");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
