using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace DataAccess.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    IdCountry = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.IdCountry);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    IdStudent = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AcceptedTerms = table.Column<bool>(nullable: false),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    BloodType = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    DrugsDescription = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    HasHealthProblem = table.Column<bool>(nullable: false),
                    HasSurgery = table.Column<bool>(nullable: false),
                    HelthProblemDescription = table.Column<string>(nullable: true),
                    Modified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    SurgeryDescription = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    UseDrugs = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.IdStudent);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    IdTeam = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.IdTeam);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    IdState = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    IdCountry = table.Column<int>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.IdState);
                    table.ForeignKey(
                        name: "FK_State_Country_IdCountry",
                        column: x => x.IdCountry,
                        principalTable: "Country",
                        principalColumn: "IdCountry",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentPhone",
                columns: table => new
                {
                    IdStudentPhone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreaCode = table.Column<int>(nullable: false),
                    CountryCode = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    IdStudent = table.Column<int>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPhone", x => x.IdStudentPhone);
                    table.ForeignKey(
                        name: "FK_StudentPhone_Student_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Student",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Academy",
                columns: table => new
                {
                    IdAcademy = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    IdTeam = table.Column<int>(nullable: false),
                    Main = table.Column<bool>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Academy", x => x.IdAcademy);
                    table.ForeignKey(
                        name: "FK_Academy_Team_IdTeam",
                        column: x => x.IdTeam,
                        principalTable: "Team",
                        principalColumn: "IdTeam",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    IdCity = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    IdState = table.Column<int>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.IdCity);
                    table.ForeignKey(
                        name: "FK_City_State_IdState",
                        column: x => x.IdState,
                        principalTable: "State",
                        principalColumn: "IdState",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademyPhone",
                columns: table => new
                {
                    IdAcademyPhone = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AreaCode = table.Column<int>(nullable: false),
                    CountryCode = table.Column<int>(nullable: false),
                    Created = table.Column<DateTime>(nullable: false),
                    IdAcademy = table.Column<int>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Number = table.Column<string>(nullable: true),
                    Type = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademyPhone", x => x.IdAcademyPhone);
                    table.ForeignKey(
                        name: "FK_AcademyPhone_Academy_IdAcademy",
                        column: x => x.IdAcademy,
                        principalTable: "Academy",
                        principalColumn: "IdAcademy",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Class",
                columns: table => new
                {
                    IdClass = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Created = table.Column<DateTime>(nullable: false),
                    IdAcademy = table.Column<int>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Class", x => x.IdClass);
                    table.ForeignKey(
                        name: "FK_Class_Academy_IdAcademy",
                        column: x => x.IdAcademy,
                        principalTable: "Academy",
                        principalColumn: "IdAcademy",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademyAddress",
                columns: table => new
                {
                    IdAcademyAddress = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Complement = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    IdAcademy = table.Column<int>(nullable: false),
                    IdCity = table.Column<int>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Neighborhood = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademyAddress", x => x.IdAcademyAddress);
                    table.ForeignKey(
                        name: "FK_AcademyAddress_Academy_IdAcademy",
                        column: x => x.IdAcademy,
                        principalTable: "Academy",
                        principalColumn: "IdAcademy",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcademyAddress_City_IdCity",
                        column: x => x.IdCity,
                        principalTable: "City",
                        principalColumn: "IdCity",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAddress",
                columns: table => new
                {
                    IdStudentAddress = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Address = table.Column<string>(nullable: true),
                    Complement = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    IdCity = table.Column<int>(nullable: false),
                    IdStudent = table.Column<int>(nullable: false),
                    Modified = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Neighborhood = table.Column<string>(nullable: true),
                    Number = table.Column<int>(nullable: false),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAddress", x => x.IdStudentAddress);
                    table.ForeignKey(
                        name: "FK_StudentAddress_City_IdCity",
                        column: x => x.IdCity,
                        principalTable: "City",
                        principalColumn: "IdCity",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAddress_Student_IdStudent",
                        column: x => x.IdStudent,
                        principalTable: "Student",
                        principalColumn: "IdStudent",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Academy_IdTeam",
                table: "Academy",
                column: "IdTeam");

            migrationBuilder.CreateIndex(
                name: "IX_AcademyAddress_IdAcademy",
                table: "AcademyAddress",
                column: "IdAcademy");

            migrationBuilder.CreateIndex(
                name: "IX_AcademyAddress_IdCity",
                table: "AcademyAddress",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "IX_AcademyPhone_IdAcademy",
                table: "AcademyPhone",
                column: "IdAcademy");

            migrationBuilder.CreateIndex(
                name: "IX_City_IdState",
                table: "City",
                column: "IdState");

            migrationBuilder.CreateIndex(
                name: "IX_Class_IdAcademy",
                table: "Class",
                column: "IdAcademy");

            migrationBuilder.CreateIndex(
                name: "IX_State_IdCountry",
                table: "State",
                column: "IdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_IdCity",
                table: "StudentAddress",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAddress_IdStudent",
                table: "StudentAddress",
                column: "IdStudent");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPhone_IdStudent",
                table: "StudentPhone",
                column: "IdStudent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcademyAddress");

            migrationBuilder.DropTable(
                name: "AcademyPhone");

            migrationBuilder.DropTable(
                name: "Class");

            migrationBuilder.DropTable(
                name: "StudentAddress");

            migrationBuilder.DropTable(
                name: "StudentPhone");

            migrationBuilder.DropTable(
                name: "Academy");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
