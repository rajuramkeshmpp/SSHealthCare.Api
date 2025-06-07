using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SSHealthCare.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfIncorporation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BusinessType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BusinessDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    StateId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomePageSidebars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechnologyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomePageSidebars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sidebars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sidebars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskManagers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TaskManagers_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TaskManagers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Address", "BusinessDescription", "BusinessType", "ContactNo", "DateOfIncorporation", "Email", "Logo", "Name", "RegistrationNumber", "Website" },
                values: new object[,]
                {
                    { 1, "Mohali,Chandigarh", "JOb", "JOb", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7410), "admin@shiwansh.com", "jobportal.png", "SS Job Portal", "111A", "http://www.dotnetinfotech.com/" },
                    { 2, "Mohali,Chandigarh", "Hospital", "Hospital", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7430), "admin@shiwansh.com", "healthcare.png", "SS Health Care", "222B", "http://www.dotnetinfotech.com/" },
                    { 3, "Mohali,Chandigarh", "Hospital", "Hospital", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7432), "admin@shiwansh.com", "healthcare.png", "SS Health Care", "333C", "http://www.dotnetinfotech.com/" },
                    { 4, "Mohali,Chandigarh", "Hospital", "Hospital", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7435), "admin@shiwansh.com", "healthcare.png", "SS Health Care", "444D", "http://www.dotnetinfotech.com/" },
                    { 5, "Mohali,Chandigarh", "Job", "Job", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7437), "admin@shiwansh.com", "jobportal.png", "SS Job Portal", "555E", "https://www.shiwansh.com/career.html" },
                    { 6, "Mohali,Chandigarh", "Job", "Job", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7440), "admin@shiwansh.com", "jobportal.png", "SS Job Portal", "666F", "https://www.shiwansh.com/career.html" },
                    { 7, "Mohali,Chandigarh", "Job", "Job", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7443), "admin@shiwansh.com", "jobportal.png", "SS Job Portal", "777G", "https://www.shiwansh.com/career.html" },
                    { 8, "Mohali,Chandigarh", "Housing", "Housing", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7445), "admin@shiwansh.com", "ehousing.png", "SS E-Housing", "888H", "https://www.shiwansh.com/career.html" },
                    { 9, "Mohali,Chandigarh", "Housing", "Housing", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7448), "admin@shiwansh.com", "ehousing.png", "SS E-Housing", "999I", "https://www.shiwansh.com/career.html" },
                    { 10, "Mohali,Chandigarh", "Housing", "Housing", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7451), "admin@shiwansh.com", "ehousing.png", "SS E-Housing", "000J", "https://www.shiwansh.com/career.html" },
                    { 11, "Mohali,Chandigarh", "Onlineshop", "Onlineshop", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7453), "admin@shiwansh.com", "sszepto.png", "SS Zepto", "K111", "http://www.dotnetinfotech.com/" },
                    { 12, "Mohali,Chandigarh", "Onlineshop", "Onlineshop", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7456), "admin@shiwansh.com", "sszepto.png", "SS Zepto", "L222", "http://www.dotnetinfotech.com/" },
                    { 13, "Mohali,Chandigarh", "Onlineshop", "Onlineshop", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7458), "admin@shiwansh.com", "sszepto.png", "SS Zepto", "M333", "http://www.dotnetinfotech.com/" },
                    { 14, "Mohali,Chandigarh", "Education", "Education", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7461), "admin@shiwansh.com", "ssschool.png", "SS School", "N444", "https://www.shiwansh.com/career.html" },
                    { 15, "Mohali,Chandigarh", "Education", "Education", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7463), "admin@shiwansh.com", "ssschool.png", "SS School", "O555", "https://www.shiwansh.com/career.html" },
                    { 16, "Mohali,Chandigarh", "Education", "Education", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7466), "admin@shiwansh.com", "ssschool.png", "SS School", "P666", "https://www.shiwansh.com/career.html" },
                    { 17, "Mohali,Chandigarh", "Education", "Education", "6280391882", new DateTime(2025, 6, 7, 10, 49, 41, 850, DateTimeKind.Local).AddTicks(7469), "homeadmin@shiwansh.com", "ssdocs.png", "SS Docs", "Q777", "https://www.shiwansh.com/career.html" }
                });

            migrationBuilder.InsertData(
                table: "HomePageSidebars",
                columns: new[] { "Id", "Name", "Path", "TechnologyId" },
                values: new object[,]
                {
                    { 1, ".Net Core Api Sql", "netcoreapi", 1 },
                    { 2, ".Net Core Api PostgreSql", "netcoreapipostgre", 1 },
                    { 3, ".Net Core Api Monodb", "netcoreapimongo", 1 },
                    { 4, "Dot Net Q/A", "dotnetqa", 1 },
                    { 5, "API with MongoDB", "nodeapimongo", 2 },
                    { 6, "API with SQL Server", "nodeapisql", 2 },
                    { 7, "API with Postgresql", "nodeapipostgre", 2 },
                    { 8, "Node Js Q/A", "nodeqa", 2 },
                    { 9, "CRUD-Static Array", "crudstaticarray", 3 },
                    { 10, "CRUD-JSON Server", "crudjsonserver", 3 },
                    { 11, "React CRUD with API", "reactcrudwithapi", 3 },
                    { 12, "React Js Q/A ", "reactqa", 3 },
                    { 13, "VS Code", "vscode", 9 },
                    { 14, "Visual Studio", "visualstudio", 9 },
                    { 15, "SQL Server", "sqlserverinstall", 9 },
                    { 16, "PostgreSql Server", "postgresqlserverinstall", 9 },
                    { 17, "MongoDB", "mongodbinstall", 9 },
                    { 18, "Node JS", "nodejs", 9 },
                    { 19, "SQL Server", "sqlserverdb", 5 },
                    { 20, "PostgreSql Server", "postgresqlserverdb", 5 },
                    { 21, "MongoDB Server", "mongodbserver", 5 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CompanyId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "SuperAdmin" },
                    { 2, 2, "HealthCareAdmin" },
                    { 3, 3, "Doctor" },
                    { 4, 4, "Patient" },
                    { 5, 5, "JobPortalAdmin" },
                    { 6, 6, "Employee" },
                    { 7, 7, "Employer" },
                    { 8, 8, "HousingAdmin" },
                    { 9, 9, "Owner" },
                    { 10, 10, "Tenant" },
                    { 11, 11, "GrosseryAdmin" },
                    { 12, 12, "Buyer" },
                    { 13, 13, "Seller" },
                    { 14, 14, "SchoolAdmin" },
                    { 15, 15, "Teacher" },
                    { 16, 16, "Student" },
                    { 17, 17, "HomeAdmin" }
                });

            migrationBuilder.InsertData(
                table: "Sidebars",
                columns: new[] { "Id", "Name", "Path", "RoleId" },
                values: new object[,]
                {
                    { 1, "Assign Role", "assignrole", 1 },
                    { 2, "Role", "role", 1 },
                    { 3, "Task Manager", "taskmanager", 1 },
                    { 4, "Doctors", "doctor", 2 },
                    { 5, "Nurses", "nurses", 2 },
                    { 6, "Patients", "patients", 2 },
                    { 7, "Reports", "healthcarereports", 2 },
                    { 8, "Billings", "billings", 2 },
                    { 9, "Rooms", "rooms", 2 },
                    { 10, "Inventory", "inventory", 2 },
                    { 11, "Appointments", "doctorappointments", 3 },
                    { 12, "Patient Records", "patientrecords", 3 },
                    { 13, "Prescriptions", "doctorprescriptions", 3 },
                    { 14, "Medical Notes", "medicalnotes", 3 },
                    { 15, "Test Reports", "testreports", 3 },
                    { 16, "Appointments", "patientappointments", 4 },
                    { 17, "Prescriptions", "patientprescriptions", 4 },
                    { 18, "Billing History", "billinghistory", 4 },
                    { 19, "Reports", "patientreports", 4 },
                    { 20, "Messages", "patientmessages", 4 },
                    { 21, "Country", "country", 2 },
                    { 22, "State", "state", 2 },
                    { 23, "District", "district", 2 },
                    { 24, "Sidebar", "sidebar", 1 },
                    { 25, "Technology", "technology", 17 },
                    { 26, "Homesidebar", "homesidebar", 17 }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Dotnet" },
                    { 2, "NodeJs" },
                    { 3, "ReactJs" },
                    { 4, "NextJs" },
                    { 5, "Database" },
                    { 6, "DevOps" },
                    { 7, "Python" },
                    { 8, "Java" },
                    { 9, "Installation" },
                    { 10, "Migration" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "Id", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 },
                    { 4, 4, 4 },
                    { 5, 5, 5 },
                    { 6, 6, 6 },
                    { 7, 7, 7 },
                    { 8, 8, 8 },
                    { 9, 9, 9 },
                    { 10, 10, 10 },
                    { 11, 11, 11 },
                    { 12, 12, 12 },
                    { 13, 13, 13 },
                    { 14, 14, 14 },
                    { 15, 15, 15 },
                    { 16, 16, 16 },
                    { 17, 17, 17 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Firstname", "Lastname", "Mobile", "Password" },
                values: new object[,]
                {
                    { 1, "shiwansh@gmail.com", "Shiwansh", "Kumar", "9876543210", "Test@123" },
                    { 2, "rajuadmin@gmail.com", "Raju", "Chauhan", "9876543211", "Test@123" },
                    { 3, "rajudoctor@gmail.com", "Raju", "Chauhan", "9876543212", "Test@123" },
                    { 4, "rajupatient@gmail.com", "Raju", "Chauhan", "9876543213", "Test@123" },
                    { 5, "vickyadmin@gmail.com", "Vicky", "Kumar", "9876543214", "Test@123" },
                    { 6, "vickyemployee@gmail.com", "Vicky", "Kumar", "9876543215", "Test@123" },
                    { 7, "vickyemployer@gmail.com", "Vicky", "Kumar", "9876543216", "Test@123" },
                    { 8, "avijitadmin@gmail.com", "Avijit", "Gorai", "9876543217", "Test@123" },
                    { 9, "avijitowner@gmail.com", "Avijit", "Gorai", "9876543218", "Test@123" },
                    { 10, "avijittenant@gmail.com", "Avijit", "Gorai", "9876543219", "Test@123" },
                    { 11, "aniladmin@gmail.com", "Anil", "Dhakad", "9876543200", "Test@123" },
                    { 12, "anilbuyer@gmail.com", "Anil", "Dhakad", "9876543220", "Test@123" },
                    { 13, "anilseller@gmail.com", "Anil", "Dhakad", "9876543310", "Test@123" },
                    { 14, "roshanadmin@gmail.com", "Roshan", "Kumar", "9876543410", "Test@123" },
                    { 15, "roshanteacher@gmail.com", "Roshan", "Kumar", "9876543510", "Test@123" },
                    { 16, "roshanstudent@gmail.com", "Roshan", "Kumar", "9876543610", "Test@123" },
                    { 17, "homeadmin@gmail.com", "Home", "Admin", "9876543610", "Test@123" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TaskManagers_StatusId",
                table: "TaskManagers",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskManagers_UserId",
                table: "TaskManagers",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "HomePageSidebars");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Sidebars");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "TaskManagers");

            migrationBuilder.DropTable(
                name: "Technologies");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
