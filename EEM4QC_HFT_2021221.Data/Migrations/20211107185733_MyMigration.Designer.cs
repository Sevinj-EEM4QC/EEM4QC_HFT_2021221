﻿// <auto-generated />
using System;
using EEM4QC_HFT_2021221.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EEM4QC_HFT_2021221.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20211107185733_MyMigration")]
    partial class MyMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EEM4QC_HFT_2021221.Models.ExitedEmployeeModel", b =>
                {
                    b.Property<int>("Exit_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ExitDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExitDetail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Exit_Id");

                    b.ToTable("Exited_Employee_Model");

                    b.HasData(
                        new
                        {
                            Exit_Id = 4,
                            ExitDate = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            ExitDetail = "passport number 2345678",
                            Name = "Zeynab",
                            Surname = "Rahim"
                        },
                        new
                        {
                            Exit_Id = 5,
                            ExitDate = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            ExitDetail = "passport number C2345671",
                            Name = "Oktay",
                            Surname = "Mammadov"
                        });
                });

            modelBuilder.Entity("EEM4QC_HFT_2021221.Models.HrEmployee", b =>
                {
                    b.Property<int>("Emp_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emp_Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Emp_Is_Existed")
                        .HasColumnType("bit");

                    b.Property<string>("Emp_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emp_Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emp_Id");

                    b.ToTable("Hr_Employees");

                    b.HasData(
                        new
                        {
                            Emp_Id = 1,
                            Emp_Code = "11",
                            Emp_Is_Existed = true,
                            Emp_Name = "Sevinj",
                            Emp_Surname = "Abdullayeva"
                        },
                        new
                        {
                            Emp_Id = 2,
                            Emp_Code = "22",
                            Emp_Is_Existed = true,
                            Emp_Name = "James",
                            Emp_Surname = "Bond"
                        },
                        new
                        {
                            Emp_Id = 3,
                            Emp_Code = "33",
                            Emp_Is_Existed = true,
                            Emp_Name = "Ilkin",
                            Emp_Surname = "Mammad"
                        },
                        new
                        {
                            Emp_Id = 4,
                            Emp_Code = "44",
                            Emp_Is_Existed = true,
                            Emp_Name = "Zeynab",
                            Emp_Surname = "Rahim"
                        },
                        new
                        {
                            Emp_Id = 5,
                            Emp_Code = "55",
                            Emp_Is_Existed = true,
                            Emp_Name = "Oktay",
                            Emp_Surname = "Mammadov"
                        });
                });

            modelBuilder.Entity("EEM4QC_HFT_2021221.Models.HrEmployeeCredentials", b =>
                {
                    b.Property<int>("Empc_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Empc_EmployeeEmp_Id")
                        .HasColumnType("int");

                    b.Property<int>("Empc_Employee_Id")
                        .HasColumnType("int");

                    b.Property<string>("Empc_Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Empc_Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Empc_Id");

                    b.HasIndex("Empc_EmployeeEmp_Id");

                    b.ToTable("Hr_Employee_Credentials");

                    b.HasData(
                        new
                        {
                            Empc_Id = 1,
                            Empc_Employee_Id = 1,
                            Empc_Mail = "sevinj160@yahoo.com",
                            Empc_Password = "sevinj"
                        },
                        new
                        {
                            Empc_Id = 2,
                            Empc_Employee_Id = 2,
                            Empc_Mail = "james@yahoo.com",
                            Empc_Password = "oktay"
                        },
                        new
                        {
                            Empc_Id = 3,
                            Empc_Employee_Id = 3,
                            Empc_Mail = "ilkin@yahoo.com",
                            Empc_Password = "ilkin123"
                        },
                        new
                        {
                            Empc_Id = 4,
                            Empc_Employee_Id = 4,
                            Empc_Mail = "zeynab@yahoo.com",
                            Empc_Password = "zeynab1"
                        },
                        new
                        {
                            Empc_Id = 5,
                            Empc_Employee_Id = 5,
                            Empc_Mail = "oktay@yahoo.com",
                            Empc_Password = "oktay27"
                        });
                });

            modelBuilder.Entity("EEM4QC_HFT_2021221.Models.HrEmployeeExitDetail", b =>
                {
                    b.Property<int>("Eed_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Eed_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eed_Details")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Eed_Employee_Work_Details_Id")
                        .HasColumnType("int");

                    b.Property<int>("Eed_Interviewer")
                        .HasColumnType("int");

                    b.Property<string>("Eed_Questions")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Eed_Id");

                    b.ToTable("Hr_Employee_Exit_Detail");

                    b.HasData(
                        new
                        {
                            Eed_Id = 1,
                            Eed_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Eed_Details = "passport number C234567",
                            Eed_Employee_Work_Details_Id = 1,
                            Eed_Interviewer = 1,
                            Eed_Questions = "no ques"
                        },
                        new
                        {
                            Eed_Id = 2,
                            Eed_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Eed_Details = "passport number C2345676",
                            Eed_Employee_Work_Details_Id = 2,
                            Eed_Interviewer = 2,
                            Eed_Questions = "no quest"
                        },
                        new
                        {
                            Eed_Id = 3,
                            Eed_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Eed_Details = "passport number 546789",
                            Eed_Employee_Work_Details_Id = 3,
                            Eed_Interviewer = 3,
                            Eed_Questions = "no question"
                        },
                        new
                        {
                            Eed_Id = 4,
                            Eed_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Eed_Details = "passport number 2345678",
                            Eed_Employee_Work_Details_Id = 4,
                            Eed_Interviewer = 4,
                            Eed_Questions = "no questns"
                        },
                        new
                        {
                            Eed_Id = 5,
                            Eed_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Eed_Details = "passport number C2345671",
                            Eed_Employee_Work_Details_Id = 5,
                            Eed_Interviewer = 5,
                            Eed_Questions = "no questions"
                        });
                });

            modelBuilder.Entity("EEM4QC_HFT_2021221.Models.HrEmployeeSalaryRecord", b =>
                {
                    b.Property<int>("Esr_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Esr_Amount")
                        .HasColumnType("float");

                    b.Property<double>("Esr_Currency")
                        .HasColumnType("float");

                    b.Property<DateTime>("Esr_Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Esr_Employee_Id")
                        .HasColumnType("int");

                    b.Property<byte>("Esr_Frequency")
                        .HasColumnType("tinyint");

                    b.Property<byte>("Esr_Hours")
                        .HasColumnType("tinyint");

                    b.Property<int>("Esr_Over_Time")
                        .HasColumnType("int");

                    b.Property<byte>("Esr_Type")
                        .HasColumnType("tinyint");

                    b.HasKey("Esr_Id");

                    b.ToTable("Hr_Employee_Salary_Record");

                    b.HasData(
                        new
                        {
                            Esr_Id = 1,
                            Esr_Amount = 2000.0,
                            Esr_Currency = 0.0,
                            Esr_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Esr_Employee_Id = 1,
                            Esr_Frequency = (byte)0,
                            Esr_Hours = (byte)1,
                            Esr_Over_Time = 1,
                            Esr_Type = (byte)1
                        },
                        new
                        {
                            Esr_Id = 2,
                            Esr_Amount = 2500.0,
                            Esr_Currency = 0.0,
                            Esr_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Esr_Employee_Id = 2,
                            Esr_Frequency = (byte)0,
                            Esr_Hours = (byte)2,
                            Esr_Over_Time = 2,
                            Esr_Type = (byte)2
                        },
                        new
                        {
                            Esr_Id = 3,
                            Esr_Amount = 3000.0,
                            Esr_Currency = 0.0,
                            Esr_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Esr_Employee_Id = 3,
                            Esr_Frequency = (byte)0,
                            Esr_Hours = (byte)3,
                            Esr_Over_Time = 3,
                            Esr_Type = (byte)3
                        },
                        new
                        {
                            Esr_Id = 4,
                            Esr_Amount = 4000.0,
                            Esr_Currency = 0.0,
                            Esr_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Esr_Employee_Id = 4,
                            Esr_Frequency = (byte)0,
                            Esr_Hours = (byte)4,
                            Esr_Over_Time = 4,
                            Esr_Type = (byte)4
                        },
                        new
                        {
                            Esr_Id = 5,
                            Esr_Amount = 5000.0,
                            Esr_Currency = 0.0,
                            Esr_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Esr_Employee_Id = 5,
                            Esr_Frequency = (byte)0,
                            Esr_Hours = (byte)5,
                            Esr_Over_Time = 5,
                            Esr_Type = (byte)5
                        });
                });

            modelBuilder.Entity("EEM4QC_HFT_2021221.Models.HrEmployeeStatus", b =>
                {
                    b.Property<int>("Emps_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Emps_Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emps_Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Emps_Id");

                    b.ToTable("Hr_Employee_Status");

                    b.HasData(
                        new
                        {
                            Emps_Id = 1,
                            Emps_Description = "1 year experience",
                            Emps_Title = "developer"
                        },
                        new
                        {
                            Emps_Id = 2,
                            Emps_Description = "2 years experience",
                            Emps_Title = "database administrator"
                        },
                        new
                        {
                            Emps_Id = 3,
                            Emps_Description = "3 years experience",
                            Emps_Title = "Programmer"
                        },
                        new
                        {
                            Emps_Id = 4,
                            Emps_Description = "4 years experience",
                            Emps_Title = "Manager"
                        },
                        new
                        {
                            Emps_Id = 5,
                            Emps_Description = "5 years experience",
                            Emps_Title = "Web designer"
                        });
                });

            modelBuilder.Entity("EEM4QC_HFT_2021221.Models.HrEmployeeWorkDetails", b =>
                {
                    b.Property<int>("Wd_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Wd_About")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Wd_Employee_Exit_Detail_Id")
                        .HasColumnType("int");

                    b.Property<int>("Wd_Employee_Id")
                        .HasColumnType("int");

                    b.Property<int>("Wd_Employee_Status_Id")
                        .HasColumnType("int");

                    b.Property<int>("Wd_Experience")
                        .HasColumnType("int");

                    b.Property<bool>("Wd_Is_Exited")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Wd_Join_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Wd_Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Wd_Manager")
                        .HasColumnType("int");

                    b.Property<string>("Wd_Summary_Job")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wd_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wd_Work_Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wd_Work_Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Wd_Id");

                    b.ToTable("Hr_Employee_Work_Details");

                    b.HasData(
                        new
                        {
                            Wd_Id = 1,
                            Wd_About = "junior 1",
                            Wd_Employee_Exit_Detail_Id = 1,
                            Wd_Employee_Id = 1,
                            Wd_Employee_Status_Id = 1,
                            Wd_Experience = 1,
                            Wd_Is_Exited = true,
                            Wd_Join_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Wd_Location = "Budapest",
                            Wd_Manager = 0,
                            Wd_Title = "developer",
                            Wd_Work_Mail = "sevinj160@yahoo.com",
                            Wd_Work_Phone = "36203106684"
                        },
                        new
                        {
                            Wd_Id = 2,
                            Wd_About = "junior 2",
                            Wd_Employee_Exit_Detail_Id = 2,
                            Wd_Employee_Id = 2,
                            Wd_Employee_Status_Id = 2,
                            Wd_Experience = 2,
                            Wd_Is_Exited = true,
                            Wd_Join_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Wd_Location = "Debrecen",
                            Wd_Manager = 0,
                            Wd_Title = "database administrator",
                            Wd_Work_Mail = "james@yahoo.com",
                            Wd_Work_Phone = "36207896656"
                        },
                        new
                        {
                            Wd_Id = 3,
                            Wd_About = "junior 3",
                            Wd_Employee_Exit_Detail_Id = 3,
                            Wd_Employee_Id = 3,
                            Wd_Employee_Status_Id = 3,
                            Wd_Experience = 3,
                            Wd_Is_Exited = true,
                            Wd_Join_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Wd_Location = "Baku",
                            Wd_Manager = 0,
                            Wd_Title = "Programmer",
                            Wd_Work_Mail = "ilkin@yahoo.com",
                            Wd_Work_Phone = "99450896656"
                        },
                        new
                        {
                            Wd_Id = 4,
                            Wd_About = "senior 4",
                            Wd_Employee_Exit_Detail_Id = 4,
                            Wd_Employee_Id = 4,
                            Wd_Employee_Status_Id = 4,
                            Wd_Experience = 4,
                            Wd_Is_Exited = true,
                            Wd_Join_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Wd_Location = "Zagatala",
                            Wd_Manager = 0,
                            Wd_Title = "Manager",
                            Wd_Work_Mail = "zeynab@yahoo.com",
                            Wd_Work_Phone = "99450797756"
                        },
                        new
                        {
                            Wd_Id = 5,
                            Wd_About = "senior 5",
                            Wd_Employee_Exit_Detail_Id = 5,
                            Wd_Employee_Id = 5,
                            Wd_Employee_Status_Id = 5,
                            Wd_Experience = 5,
                            Wd_Is_Exited = false,
                            Wd_Join_Date = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Wd_Location = "Prague",
                            Wd_Manager = 0,
                            Wd_Title = "Web designer",
                            Wd_Work_Mail = "oktay@yahoo.com",
                            Wd_Work_Phone = "42045678756"
                        });
                });

            modelBuilder.Entity("EEM4QC_HFT_2021221.Models.UnExitedEmployeeModel", b =>
                {
                    b.Property<int>("Unexit_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("JoinedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Unexit_Id");

                    b.ToTable("UnExited_Employee_Model");

                    b.HasData(
                        new
                        {
                            Unexit_Id = 1,
                            JoinedDate = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Location = "Budapest",
                            Mail = "sevinj@yahoo.com",
                            Name = "Sevinj",
                            Phone = "36203106684",
                            Salary = 2000.0,
                            Summary = "non",
                            Surname = "Abdullayeva",
                            Title = "Sev"
                        },
                        new
                        {
                            Unexit_Id = 2,
                            JoinedDate = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Location = "Debrecen",
                            Mail = "james@yahoo.com",
                            Name = "James",
                            Phone = "36207896656",
                            Salary = 2500.0,
                            Summary = "non",
                            Surname = "Bond",
                            Title = "JamesB"
                        },
                        new
                        {
                            Unexit_Id = 3,
                            JoinedDate = new DateTime(2021, 11, 7, 0, 0, 0, 0, DateTimeKind.Local),
                            Location = "Baku",
                            Mail = "ilkin@yahoo.com",
                            Name = "Ilkin",
                            Phone = "99450896656",
                            Salary = 3000.0,
                            Summary = "non",
                            Surname = "Mammad",
                            Title = "IlkinM"
                        });
                });

            modelBuilder.Entity("EEM4QC_HFT_2021221.Models.HrEmployeeCredentials", b =>
                {
                    b.HasOne("EEM4QC_HFT_2021221.Models.HrEmployee", "Empc_Employee")
                        .WithMany()
                        .HasForeignKey("Empc_EmployeeEmp_Id");

                    b.Navigation("Empc_Employee");
                });
#pragma warning restore 612, 618
        }
    }
}