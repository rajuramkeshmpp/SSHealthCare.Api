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
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
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

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "jobportal.png", "SS Job Portal" },
                    { 2, "healthcare.png", "SS Health Care" },
                    { 3, "healthcare.png", "SS Health Care" },
                    { 4, "healthcare.png", "SS Health Care" },
                    { 5, "jobportal.png", "SS Job Portal" },
                    { 6, "jobportal.png", "SS Job Portal" },
                    { 7, "jobportal.png", "SS Job Portal" },
                    { 8, "ehousing.png", "SS E-Housing" },
                    { 9, "ehousing.png", "SS E-Housing" },
                    { 10, "ehousing.png", "SS E-Housing" },
                    { 11, "sszepto.png", "SS Zepto" },
                    { 12, "sszepto.png", "SS Zepto" },
                    { 13, "sszepto.png", "SS Zepto" },
                    { 14, "ssschool.png", "SS School" },
                    { 15, "ssschool.png", "SS School" },
                    { 16, "ssschool.png", "SS School" }
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
                    { 16, 16, "Student" }
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
                    { 24, "Sidebar", "sidebar", 1 }
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
                    { 16, 16, 16 }
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
                    { 16, "roshanstudent@gmail.com", "Roshan", "Kumar", "9876543610", "Test@123" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Sidebars");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "TaskManagers");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
