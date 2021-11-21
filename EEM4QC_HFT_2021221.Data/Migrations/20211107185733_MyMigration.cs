using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EEM4QC_HFT_2021221.Data.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hr_Employee_Status_Hr_Employees_HrEmployeeEmp_Id",
                table: "Hr_Employee_Status");

            migrationBuilder.DropIndex(
                name: "IX_Hr_Employee_Status_HrEmployeeEmp_Id",
                table: "Hr_Employee_Status");

            migrationBuilder.DropColumn(
                name: "HrEmployeeEmp_Id",
                table: "Hr_Employee_Status");

            migrationBuilder.CreateTable(
                name: "Exited_Employee_Model",
                columns: table => new
                {
                    Exit_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExitDetail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExitDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exited_Employee_Model", x => x.Exit_Id);
                });

            migrationBuilder.CreateTable(
                name: "Hr_Employee_Exit_Detail",
                columns: table => new
                {
                    Eed_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Eed_Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eed_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Eed_Questions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Eed_Interviewer = table.Column<int>(type: "int", nullable: false),
                    Eed_Employee_Work_Details_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_Employee_Exit_Detail", x => x.Eed_Id);
                });

            migrationBuilder.CreateTable(
                name: "Hr_Employee_Salary_Record",
                columns: table => new
                {
                    Esr_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Esr_Currency = table.Column<double>(type: "float", nullable: false),
                    Esr_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Esr_Hours = table.Column<byte>(type: "tinyint", nullable: false),
                    Esr_Over_Time = table.Column<int>(type: "int", nullable: false),
                    Esr_Amount = table.Column<double>(type: "float", nullable: false),
                    Esr_Type = table.Column<byte>(type: "tinyint", nullable: false),
                    Esr_Frequency = table.Column<byte>(type: "tinyint", nullable: false),
                    Esr_Employee_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hr_Employee_Salary_Record", x => x.Esr_Id);
                });

            migrationBuilder.CreateTable(
                name: "UnExited_Employee_Model",
                columns: table => new
                {
                    Unexit_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JoinedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Salary = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnExited_Employee_Model", x => x.Unexit_Id);
                });

            migrationBuilder.InsertData(
                table: "Exited_Employee_Model",
                columns: new[] { "Exit_Id", "ExitDate", "ExitDetail", "Name", "Surname" },
                values: new object[,]
                {
                    { 4, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "passport number 2345678", "Zeynab", "Rahim" },
                    { 5, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "passport number C2345671", "Oktay", "Mammadov" }
                });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Credentials",
                keyColumn: "Empc_Id",
                keyValue: 2,
                column: "Empc_Mail",
                value: "james@yahoo.com");

            migrationBuilder.InsertData(
                table: "Hr_Employee_Credentials",
                columns: new[] { "Empc_Id", "Empc_EmployeeEmp_Id", "Empc_Employee_Id", "Empc_Mail", "Empc_Password" },
                values: new object[,]
                {
                    { 3, null, 3, "ilkin@yahoo.com", "ilkin123" },
                    { 4, null, 4, "zeynab@yahoo.com", "zeynab1" },
                    { 5, null, 5, "oktay@yahoo.com", "oktay27" }
                });

            migrationBuilder.InsertData(
                table: "Hr_Employee_Exit_Detail",
                columns: new[] { "Eed_Id", "Eed_Date", "Eed_Details", "Eed_Employee_Work_Details_Id", "Eed_Interviewer", "Eed_Questions" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "passport number C234567", 1, 1, "no ques" },
                    { 2, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "passport number C2345676", 2, 2, "no quest" },
                    { 3, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "passport number 546789", 3, 3, "no question" },
                    { 4, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "passport number 2345678", 4, 4, "no questns" },
                    { 5, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "passport number C2345671", 5, 5, "no questions" }
                });

            migrationBuilder.InsertData(
                table: "Hr_Employee_Salary_Record",
                columns: new[] { "Esr_Id", "Esr_Amount", "Esr_Currency", "Esr_Date", "Esr_Employee_Id", "Esr_Frequency", "Esr_Hours", "Esr_Over_Time", "Esr_Type" },
                values: new object[,]
                {
                    { 5, 5000.0, 0.0, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 5, (byte)0, (byte)5, 5, (byte)5 },
                    { 3, 3000.0, 0.0, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 3, (byte)0, (byte)3, 3, (byte)3 },
                    { 2, 2500.0, 0.0, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 2, (byte)0, (byte)2, 2, (byte)2 },
                    { 4, 4000.0, 0.0, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 4, (byte)0, (byte)4, 4, (byte)4 },
                    { 1, 2000.0, 0.0, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), 1, (byte)0, (byte)1, 1, (byte)1 }
                });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 1,
                column: "Emps_Description",
                value: "1 year experience");

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 2,
                column: "Emps_Description",
                value: "2 years experience");

            migrationBuilder.InsertData(
                table: "Hr_Employee_Status",
                columns: new[] { "Emps_Id", "Emps_Description", "Emps_Title" },
                values: new object[,]
                {
                    { 3, "3 years experience", "Programmer" },
                    { 4, "4 years experience", "Manager" },
                    { 5, "5 years experience", "Web designer" }
                });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 1,
                columns: new[] { "Wd_About", "Wd_Experience", "Wd_Is_Exited", "Wd_Join_Date" },
                values: new object[] { "junior 1", 1, true, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 2,
                columns: new[] { "Wd_About", "Wd_Experience", "Wd_Is_Exited", "Wd_Join_Date", "Wd_Work_Mail" },
                values: new object[] { "junior 2", 2, true, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "james@yahoo.com" });

            migrationBuilder.InsertData(
                table: "Hr_Employee_Work_Details",
                columns: new[] { "Wd_Id", "Wd_About", "Wd_Employee_Exit_Detail_Id", "Wd_Employee_Id", "Wd_Employee_Status_Id", "Wd_Experience", "Wd_Is_Exited", "Wd_Join_Date", "Wd_Location", "Wd_Manager", "Wd_Summary_Job", "Wd_Title", "Wd_Work_Mail", "Wd_Work_Phone" },
                values: new object[,]
                {
                    { 3, "junior 3", 3, 3, 3, 3, true, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Baku", 0, null, "Programmer", "ilkin@yahoo.com", "99450896656" },
                    { 4, "senior 4", 4, 4, 4, 4, true, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Zagatala", 0, null, "Manager", "zeynab@yahoo.com", "99450797756" },
                    { 5, "senior 5", 5, 5, 5, 5, false, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Prague", 0, null, "Web designer", "oktay@yahoo.com", "42045678756" }
                });

            migrationBuilder.UpdateData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 1,
                columns: new[] { "Emp_Code", "Emp_Is_Existed" },
                values: new object[] { "11", true });

            migrationBuilder.UpdateData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 2,
                columns: new[] { "Emp_Code", "Emp_Is_Existed" },
                values: new object[] { "22", true });

            migrationBuilder.InsertData(
                table: "Hr_Employees",
                columns: new[] { "Emp_Id", "Emp_Code", "Emp_Is_Existed", "Emp_Name", "Emp_Surname" },
                values: new object[,]
                {
                    { 3, "33", true, "Ilkin", "Mammad" },
                    { 5, "55", true, "Oktay", "Mammadov" },
                    { 4, "44", true, "Zeynab", "Rahim" }
                });

            migrationBuilder.InsertData(
                table: "UnExited_Employee_Model",
                columns: new[] { "Unexit_Id", "JoinedDate", "Location", "Mail", "Name", "Phone", "Salary", "Summary", "Surname", "Title" },
                values: new object[,]
                {
                    { 2, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Debrecen", "james@yahoo.com", "James", "36207896656", 2500.0, "non", "Bond", "JamesB" },
                    { 3, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Baku", "ilkin@yahoo.com", "Ilkin", "99450896656", 3000.0, "non", "Mammad", "IlkinM" },
                    { 1, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Budapest", "sevinj@yahoo.com", "Sevinj", "36203106684", 2000.0, "non", "Abdullayeva", "Sev" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exited_Employee_Model");

            migrationBuilder.DropTable(
                name: "Hr_Employee_Exit_Detail");

            migrationBuilder.DropTable(
                name: "Hr_Employee_Salary_Record");

            migrationBuilder.DropTable(
                name: "UnExited_Employee_Model");

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Credentials",
                keyColumn: "Empc_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Credentials",
                keyColumn: "Empc_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Credentials",
                keyColumn: "Empc_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 5);

            migrationBuilder.AddColumn<int>(
                name: "HrEmployeeEmp_Id",
                table: "Hr_Employee_Status",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Credentials",
                keyColumn: "Empc_Id",
                keyValue: 2,
                column: "Empc_Mail",
                value: "oktay0@yahoo.com");

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 1,
                column: "Emps_Description",
                value: "5 years experience");

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 2,
                column: "Emps_Description",
                value: "1 year experience");

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 1,
                columns: new[] { "Wd_About", "Wd_Experience", "Wd_Is_Exited", "Wd_Join_Date" },
                values: new object[] { null, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 2,
                columns: new[] { "Wd_About", "Wd_Experience", "Wd_Is_Exited", "Wd_Join_Date", "Wd_Work_Mail" },
                values: new object[] { null, 0, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "oktay0@yahoo.com" });

            migrationBuilder.UpdateData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 1,
                columns: new[] { "Emp_Code", "Emp_Is_Existed" },
                values: new object[] { "1", false });

            migrationBuilder.UpdateData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 2,
                columns: new[] { "Emp_Code", "Emp_Is_Existed" },
                values: new object[] { "2", false });

            migrationBuilder.CreateIndex(
                name: "IX_Hr_Employee_Status_HrEmployeeEmp_Id",
                table: "Hr_Employee_Status",
                column: "HrEmployeeEmp_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Hr_Employee_Status_Hr_Employees_HrEmployeeEmp_Id",
                table: "Hr_Employee_Status",
                column: "HrEmployeeEmp_Id",
                principalTable: "Hr_Employees",
                principalColumn: "Emp_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
