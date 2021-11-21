using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EEM4QC_HFT_2021221.Data.Migrations
{
    public partial class NewMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exited_Employee_Model",
                keyColumn: "Exit_Id",
                keyValue: 4,
                column: "ExitDate",
                value: new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Exited_Employee_Model",
                keyColumn: "Exit_Id",
                keyValue: 5,
                column: "ExitDate",
                value: new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Hr_Employee_Credentials",
                columns: new[] { "Empc_Id", "Empc_EmployeeEmp_Id", "Empc_Employee_Id", "Empc_Mail", "Empc_Password" },
                values: new object[,]
                {
                    { 10, null, 10, "saleh@yahoo.com", "saleh1" },
                    { 9, null, 9, "tommy@yahoo.com", "tommy1" },
                    { 6, null, 6, "buse@yahoo.com", "buse1" },
                    { 7, null, 7, "altay@yahoo.com", "altay1" },
                    { 8, null, 8, "olive@yahoo.com", "olive1" }
                });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 1,
                columns: new[] { "Eed_Date", "Eed_Questions" },
                values: new object[] { new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "non" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 2,
                columns: new[] { "Eed_Date", "Eed_Questions" },
                values: new object[] { new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "non" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 3,
                columns: new[] { "Eed_Date", "Eed_Questions" },
                values: new object[] { new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "non" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 4,
                columns: new[] { "Eed_Date", "Eed_Questions" },
                values: new object[] { new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "non" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 5,
                columns: new[] { "Eed_Date", "Eed_Questions" },
                values: new object[] { new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "non" });

            migrationBuilder.InsertData(
                table: "Hr_Employee_Exit_Detail",
                columns: new[] { "Eed_Id", "Eed_Date", "Eed_Details", "Eed_Employee_Work_Details_Id", "Eed_Interviewer", "Eed_Questions" },
                values: new object[,]
                {
                    { 6, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "passport number C2656341", 6, 6, "non" },
                    { 7, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "passport number 34567876", 7, 7, "non" },
                    { 8, new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "passport number 98765431", 8, 8, "non" },
                    { 9, new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "passport number C2309871", 9, 9, "non" },
                    { 10, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "passport number C2345991", 10, 10, "non" }
                });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 1,
                column: "Esr_Date",
                value: new DateTime(2022, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 2,
                column: "Esr_Date",
                value: new DateTime(2022, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 3,
                column: "Esr_Date",
                value: new DateTime(2022, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 4,
                column: "Esr_Date",
                value: new DateTime(2022, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 5,
                column: "Esr_Date",
                value: new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Hr_Employee_Salary_Record",
                columns: new[] { "Esr_Id", "Esr_Amount", "Esr_Currency", "Esr_Date", "Esr_Employee_Id", "Esr_Frequency", "Esr_Hours", "Esr_Over_Time", "Esr_Type" },
                values: new object[,]
                {
                    { 9, 9000.0, 0.0, new DateTime(2022, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, (byte)0, (byte)9, 9, (byte)9 },
                    { 8, 30000.0, 0.0, new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, (byte)0, (byte)8, 8, (byte)8 },
                    { 7, 10000.0, 0.0, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, (byte)0, (byte)7, 7, (byte)7 },
                    { 6, 300.0, 0.0, new DateTime(2022, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, (byte)0, (byte)6, 6, (byte)6 },
                    { 10, 11000.0, 0.0, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, (byte)0, (byte)10, 10, (byte)10 }
                });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 1,
                column: "Emps_Title",
                value: "Web designer");

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 2,
                column: "Emps_Title",
                value: "Database administrator");

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 5,
                column: "Emps_Title",
                value: "Developer");

            migrationBuilder.InsertData(
                table: "Hr_Employee_Status",
                columns: new[] { "Emps_Id", "Emps_Description", "Emps_Title" },
                values: new object[,]
                {
                    { 8, "8 years experience", "Director" },
                    { 10, "10 years experience", "Driver" },
                    { 9, "9 years experience", "Teacher" },
                    { 7, "7 years experience", "Assistant" },
                    { 6, "3 months experience", "Jr. developer" }
                });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 1,
                columns: new[] { "Wd_Is_Exited", "Wd_Join_Date", "Wd_Title" },
                values: new object[] { false, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Web designer" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 2,
                columns: new[] { "Wd_Is_Exited", "Wd_Join_Date", "Wd_Title" },
                values: new object[] { false, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Database administrator" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 3,
                columns: new[] { "Wd_Is_Exited", "Wd_Join_Date" },
                values: new object[] { false, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 4,
                column: "Wd_Join_Date",
                value: new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 5,
                columns: new[] { "Wd_Is_Exited", "Wd_Join_Date", "Wd_Title" },
                values: new object[] { true, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Developer" });

            migrationBuilder.InsertData(
                table: "Hr_Employee_Work_Details",
                columns: new[] { "Wd_Id", "Wd_About", "Wd_Employee_Exit_Detail_Id", "Wd_Employee_Id", "Wd_Employee_Status_Id", "Wd_Experience", "Wd_Is_Exited", "Wd_Join_Date", "Wd_Location", "Wd_Manager", "Wd_Summary_Job", "Wd_Title", "Wd_Work_Mail", "Wd_Work_Phone" },
                values: new object[,]
                {
                    { 8, "senior 8", 8, 8, 8, 8, false, new DateTime(2021, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dresden", 0, null, "Director", "olive@yahoo.com", "9945457756" },
                    { 7, "senior 7", 7, 7, 7, 7, false, new DateTime(2021, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Istanbul", 0, null, "Assistant", "altay@yahoo.com", "44250797756" }
                });

            migrationBuilder.InsertData(
                table: "Hr_Employee_Work_Details",
                columns: new[] { "Wd_Id", "Wd_About", "Wd_Employee_Exit_Detail_Id", "Wd_Employee_Id", "Wd_Employee_Status_Id", "Wd_Experience", "Wd_Is_Exited", "Wd_Join_Date", "Wd_Location", "Wd_Manager", "Wd_Summary_Job", "Wd_Title", "Wd_Work_Mail", "Wd_Work_Phone" },
                values: new object[,]
                {
                    { 6, "junior 3m", 6, 6, 6, 6, false, new DateTime(2021, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paris", 0, null, "Jr. developer", "buse@yahoo.com", "1550797756" },
                    { 10, "senior 10", 10, 10, 10, 10, false, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miskolc", 0, null, "Driver", "saleh@yahoo.com", "3620697756" },
                    { 9, "senior 9", 9, 9, 9, 9, false, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", 0, null, "Teacher", "tommy@yahoo.com", "99450798760" }
                });

            migrationBuilder.InsertData(
                table: "Hr_Employees",
                columns: new[] { "Emp_Id", "Emp_Code", "Emp_Is_Existed", "Emp_Name", "Emp_Surname" },
                values: new object[,]
                {
                    { 6, "66", true, "Buse", "Su" },
                    { 10, "1010", true, "Saleh", "Terim" },
                    { 9, "99", true, "Tommy", "Tomson" },
                    { 8, "88", true, "Olive", "Mah" },
                    { 7, "77", true, "Altay", "Aliyev" }
                });

            migrationBuilder.UpdateData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 1,
                column: "JoinedDate",
                value: new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 2,
                column: "JoinedDate",
                value: new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 3,
                column: "JoinedDate",
                value: new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "UnExited_Employee_Model",
                columns: new[] { "Unexit_Id", "JoinedDate", "Location", "Mail", "Name", "Phone", "Salary", "Summary", "Surname", "Title" },
                values: new object[,]
                {
                    { 9, new DateTime(2021, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "New York", "tommy@yahoo.com", "Tommy", "99450798760", 9000.0, "non", "Tomson", "TommyT" },
                    { 8, new DateTime(2022, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dresden", "olive@yahoo.com", "OLive", "9945457756", 30000.0, "non", "Mah", "OliveM" },
                    { 7, new DateTime(2022, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Istanbul", "altay@yahoo.com", "Altay", "44250797756", 10000.0, "non", "Aliyev", "AltayA" },
                    { 6, new DateTime(2022, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paris", "buse@yahoo.com", "Buse", "1550797756", 300.0, "non", "Su", "Buse" },
                    { 10, new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Miskolc", "saleh@yahoo.com", "Saleh", "3620697756", 11000.0, "non", "Terim", "SalehT" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hr_Employee_Credentials",
                keyColumn: "Empc_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Credentials",
                keyColumn: "Empc_Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Credentials",
                keyColumn: "Empc_Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Credentials",
                keyColumn: "Empc_Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Credentials",
                keyColumn: "Empc_Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Hr_Employees",
                keyColumn: "Emp_Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Exited_Employee_Model",
                keyColumn: "Exit_Id",
                keyValue: 4,
                column: "ExitDate",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Exited_Employee_Model",
                keyColumn: "Exit_Id",
                keyValue: 5,
                column: "ExitDate",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 1,
                columns: new[] { "Eed_Date", "Eed_Questions" },
                values: new object[] { new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "no ques" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 2,
                columns: new[] { "Eed_Date", "Eed_Questions" },
                values: new object[] { new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "no quest" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 3,
                columns: new[] { "Eed_Date", "Eed_Questions" },
                values: new object[] { new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "no question" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 4,
                columns: new[] { "Eed_Date", "Eed_Questions" },
                values: new object[] { new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "no questns" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Exit_Detail",
                keyColumn: "Eed_Id",
                keyValue: 5,
                columns: new[] { "Eed_Date", "Eed_Questions" },
                values: new object[] { new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "no questions" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 1,
                column: "Esr_Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 2,
                column: "Esr_Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 3,
                column: "Esr_Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 4,
                column: "Esr_Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Salary_Record",
                keyColumn: "Esr_Id",
                keyValue: 5,
                column: "Esr_Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 1,
                column: "Emps_Title",
                value: "developer");

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 2,
                column: "Emps_Title",
                value: "database administrator");

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Status",
                keyColumn: "Emps_Id",
                keyValue: 5,
                column: "Emps_Title",
                value: "Web designer");

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 1,
                columns: new[] { "Wd_Is_Exited", "Wd_Join_Date", "Wd_Title" },
                values: new object[] { true, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "developer" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 2,
                columns: new[] { "Wd_Is_Exited", "Wd_Join_Date", "Wd_Title" },
                values: new object[] { true, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "database administrator" });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 3,
                columns: new[] { "Wd_Is_Exited", "Wd_Join_Date" },
                values: new object[] { true, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 4,
                column: "Wd_Join_Date",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Hr_Employee_Work_Details",
                keyColumn: "Wd_Id",
                keyValue: 5,
                columns: new[] { "Wd_Is_Exited", "Wd_Join_Date", "Wd_Title" },
                values: new object[] { false, new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local), "Web designer" });

            migrationBuilder.UpdateData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 1,
                column: "JoinedDate",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 2,
                column: "JoinedDate",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UnExited_Employee_Model",
                keyColumn: "Unexit_Id",
                keyValue: 3,
                column: "JoinedDate",
                value: new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
