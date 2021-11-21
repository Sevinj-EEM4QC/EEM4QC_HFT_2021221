using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EEM4QC_HFT_2021221.Data.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hr_Employee_Work_Details",
                columns: table => new
                {
                    Wd_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Wd_Manager = table.Column<int>(type: "int", nullable: false),
                    Wd_Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wd_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wd_Join_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Wd_Experience = table.Column<int>(type: "int", nullable: false),
                    Wd_Work_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wd_Work_Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wd_Summary_Job = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wd_About = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wd_Employee_Status_Id = table.Column<int>(type: "int", nullable: false),
                    Wd_Employee_Id = table.Column<int>(type: "int", nullable: false),
                    Wd_Is_Exited = table.Column<bool>(type: "bit", nullable: false),
                    Wd_Employee_Exit_Detail_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_Employee_Work_Details", x => x.Wd_Id);
                });

            migrationBuilder.CreateTable(
                name: "Hr_Employees",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Is_Existed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_Employees", x => x.Emp_Id);
                });

            migrationBuilder.CreateTable(
                name: "Hr_Employee_Credentials",
                columns: table => new
                {
                    Empc_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Empc_Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empc_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Empc_Employee_Id = table.Column<int>(type: "int", nullable: false),
                    Empc_EmployeeEmp_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_Employee_Credentials", x => x.Empc_Id);
                    table.ForeignKey(
                        name: "FK_Hr_Employee_Credentials_Hr_Employees_Empc_EmployeeEmp_Id",
                        column: x => x.Empc_EmployeeEmp_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "Emp_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hr_Employee_Status",
                columns: table => new
                {
                    Emps_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emps_Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emps_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HrEmployeeEmp_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_Employee_Status", x => x.Emps_Id);
                    table.ForeignKey(
                        name: "FK_Hr_Employee_Status_Hr_Employees_HrEmployeeEmp_Id",
                        column: x => x.HrEmployeeEmp_Id,
                        principalTable: "Hr_Employees",
                        principalColumn: "Emp_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Hr_Employee_Credentials",
                columns: new[] { "Empc_Id", "Empc_EmployeeEmp_Id", "Empc_Employee_Id", "Empc_Mail", "Empc_Password" },
                values: new object[,]
                {
                    { 1, null, 1, "sevinj160@yahoo.com", "sevinj" },
                    { 2, null, 2, "oktay0@yahoo.com", "oktay" }
                });

            migrationBuilder.InsertData(
                table: "Hr_Employee_Status",
                columns: new[] { "Emps_Id", "Emps_Description", "Emps_Title", "HrEmployeeEmp_Id" },
                values: new object[,]
                {
                    { 1, "5 years experience", "developer", null },
                    { 2, "1 year experience", "database administrator", null }
                });

            migrationBuilder.InsertData(
                table: "Hr_Employee_Work_Details",
                columns: new[] { "Wd_Id", "Wd_About", "Wd_Employee_Exit_Detail_Id", "Wd_Employee_Id", "Wd_Employee_Status_Id", "Wd_Experience", "Wd_Is_Exited", "Wd_Join_Date", "Wd_Location", "Wd_Manager", "Wd_Summary_Job", "Wd_Title", "Wd_Work_Mail", "Wd_Work_Phone" },
                values: new object[,]
                {
                    { 1, null, 1, 1, 1, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Budapest", 0, null, "developer", "sevinj160@yahoo.com", "36203106684" },
                    { 2, null, 2, 2, 2, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Debrecen", 0, null, "database administrator", "oktay0@yahoo.com", "36207896656" }
                });

            migrationBuilder.InsertData(
                table: "Hr_Employees",
                columns: new[] { "Emp_Id", "Emp_Code", "Emp_Is_Existed", "Emp_Name", "Emp_Surname" },
                values: new object[,]
                {
                    { 1, "1", false, "Sevinj", "Abdullayeva" },
                    { 2, "2", false, "James", "Bond" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hr_Employee_Credentials_Empc_EmployeeEmp_Id",
                table: "Hr_Employee_Credentials",
                column: "Empc_EmployeeEmp_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Hr_Employee_Status_HrEmployeeEmp_Id",
                table: "Hr_Employee_Status",
                column: "HrEmployeeEmp_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hr_Employee_Credentials");

            migrationBuilder.DropTable(
                name: "Hr_Employee_Status");

            migrationBuilder.DropTable(
                name: "Hr_Employee_Work_Details");

            migrationBuilder.DropTable(
                name: "Hr_Employees");
        }
    }
}
