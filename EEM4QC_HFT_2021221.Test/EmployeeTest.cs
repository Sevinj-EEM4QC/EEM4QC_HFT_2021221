// <copyright file="EmployeeTest.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace EEM4QC_HFT_2021221.Test
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using EEM4QC_HFT_2021221.Data;
    using EEM4QC_HFT_2021221.Logic;
    using EEM4QC_HFT_2021221.Models;
    using EEM4QC_HFT_2021221.Repository;
    using Moq;
    using NUnit.Framework;

    /// <summary>
    /// Employee test.
    /// </summary>
    [TestFixture]
    public class EmployeeTest
    {
        /// <summary>
        /// Employee list .
        /// </summary>
        /// <returns>Task.</returns>
        [Test]
        public Task EmployeeList()
            => Task.Run(() =>
            {
                using DataContext context = new DataContext();
                IBaseLogic logic = new BaseLogic(new BaseRepository(context));

                List<HrEmployee> employees = new List<HrEmployee>
                {
                   new HrEmployee { Emp_Name = "Sevinj", Emp_Id = 1, Emp_Is_Existed = true, Emp_Code = "11", Emp_Surname = "Abdullayeva" },
                   new HrEmployee { Emp_Name = "James", Emp_Id = 2, Emp_Is_Existed = true, Emp_Code = "22", Emp_Surname = "Bond" },
                   new HrEmployee { Emp_Name = "Ilkin", Emp_Id = 3, Emp_Is_Existed = true, Emp_Code = "33", Emp_Surname = "Mammad" },
                   new HrEmployee { Emp_Name = "Zeynab", Emp_Id = 4, Emp_Is_Existed = true, Emp_Code = "44", Emp_Surname = "Rahim" },
                   new HrEmployee { Emp_Name = "Oktay", Emp_Id = 5, Emp_Is_Existed = true, Emp_Code = "55", Emp_Surname = "Mammadov" },
                   new HrEmployee { Emp_Name = "Buse", Emp_Id = 6, Emp_Is_Existed = true, Emp_Code = "66", Emp_Surname = "Su" },
                   new HrEmployee { Emp_Name = "Altay", Emp_Id = 7, Emp_Is_Existed = true, Emp_Code = "77", Emp_Surname = "Aliyev" },
                   new HrEmployee { Emp_Name = "Olive", Emp_Id = 8, Emp_Is_Existed = true, Emp_Code = "88", Emp_Surname = "Mah" },
                   new HrEmployee { Emp_Name = "Tommy", Emp_Id = 9, Emp_Is_Existed = true, Emp_Code = "99", Emp_Surname = "Tomson" },
                   new HrEmployee { Emp_Name = "Saleh", Emp_Id = 10, Emp_Is_Existed = true, Emp_Code = "1010", Emp_Surname = "Terim" },
                };

                var all = logic.EmployeeLogic.GetList();

                Assert.NotNull(all);
            });

        /// <summary>
        /// Exited employee list .
        /// </summary>
        [Test]
        public void UnExitedEmployeeList()
        {
            using DataContext context = new DataContext();
            IBaseLogic logic = new BaseLogic(new BaseRepository(context));
            Mock<IEmployeeExitDetailRepository> mockRepo = new Mock<IEmployeeExitDetailRepository>();
            List<HrEmployeeExitDetail> employeeExitDetails = new List<HrEmployeeExitDetail>
            {
                new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 1), Eed_Employee_Work_Details_Id = 1, Eed_Details = "passport number C234567", Eed_Interviewer = 1, Eed_Questions = "non", Eed_Id = 1 },
                new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 2), Eed_Employee_Work_Details_Id = 2, Eed_Details = "passport number C2345676", Eed_Interviewer = 2, Eed_Questions = "non", Eed_Id = 2 },
                new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 3), Eed_Employee_Work_Details_Id = 3, Eed_Details = "passport number 546789", Eed_Interviewer = 3, Eed_Questions = "non", Eed_Id = 3 },
                new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 4), Eed_Employee_Work_Details_Id = 4, Eed_Details = "passport number 2345678", Eed_Interviewer = 4, Eed_Questions = "non", Eed_Id = 4 },
                new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 5), Eed_Employee_Work_Details_Id = 5, Eed_Details = "passport number C2345671", Eed_Interviewer = 5, Eed_Questions = "non", Eed_Id = 5 },
                new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 6), Eed_Employee_Work_Details_Id = 6, Eed_Details = "passport number C2656341", Eed_Interviewer = 6, Eed_Questions = "non", Eed_Id = 6 },
                new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 7), Eed_Employee_Work_Details_Id = 7, Eed_Details = "passport number 34567876", Eed_Interviewer = 7, Eed_Questions = "non", Eed_Id = 7 },
                new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 8), Eed_Employee_Work_Details_Id = 8, Eed_Details = "passport number 98765431", Eed_Interviewer = 8, Eed_Questions = "non", Eed_Id = 8 },
                new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 9), Eed_Employee_Work_Details_Id = 9, Eed_Details = "passport number C2309871", Eed_Interviewer = 9, Eed_Questions = "non", Eed_Id = 9 },
                new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 10), Eed_Employee_Work_Details_Id = 10, Eed_Details = "passport number C2345991", Eed_Interviewer = 10, Eed_Questions = "non", Eed_Id = 10 },
            };
            var employeeExitDetail = new HrEmployeeExitDetail { Eed_Date = new DateTime(2022, 12, 5), Eed_Employee_Work_Details_Id = 5, Eed_Details = "passport number C2345671", Eed_Interviewer = 5, Eed_Questions = "non", Eed_Id = 5 };

            mockRepo.Setup(x => x.GetSingle(1)).Returns(employeeExitDetail);

            var allUnexiteds = logic.EmployeeLogic.GetUnExitedEmployees();

            Assert.NotNull(allUnexiteds);
        }

        /// <summary>
        /// Unexited employee list .
        /// </summary>
        [Test]
        public void ExitedEmployeeList()
        {
            using DataContext context = new DataContext();
            IBaseLogic logic = new BaseLogic(new BaseRepository(context));

            var exiteds = logic.EmployeeLogic.GetUnExitedEmployees();

            Assert.NotNull(exiteds);
        }

        /// <summary>
        /// Exited employee list .
        /// </summary>
        [Test]
        public void AcceptedEmployeesList()
        {
            using DataContext context = new DataContext();
            IBaseLogic logic = new BaseLogic(new BaseRepository(context));
            Mock<IEmployeeStatusRepository> mockRepo = new Mock<IEmployeeStatusRepository>();
            List<HrEmployeeStatus> employeeStatuses = new List<HrEmployeeStatus>
            {
                new HrEmployeeStatus { Emps_Id = 1, Emps_Title = "Web designer", Emps_Description = "1 year experience" },
                new HrEmployeeStatus { Emps_Id = 2, Emps_Title = "Database administrator", Emps_Description = "2 years experience" },
                new HrEmployeeStatus { Emps_Id = 3, Emps_Title = "Programmer", Emps_Description = "3 years experience" },
                new HrEmployeeStatus { Emps_Id = 4, Emps_Title = "Manager", Emps_Description = "4 years experience" },
                new HrEmployeeStatus { Emps_Id = 5, Emps_Title = "Developer", Emps_Description = "5 years experience" },
                new HrEmployeeStatus { Emps_Id = 6, Emps_Title = "Jr. developer", Emps_Description = "3 months experience" },
                new HrEmployeeStatus { Emps_Id = 7, Emps_Title = "Assistant", Emps_Description = "7 years experience" },
                new HrEmployeeStatus { Emps_Id = 8, Emps_Title = "Director", Emps_Description = " years experience" },
                new HrEmployeeStatus { Emps_Id = 9, Emps_Title = "Teacher", Emps_Description = "9 years experience" },
                new HrEmployeeStatus { Emps_Id = 10, Emps_Title = "Driver", Emps_Description = "10 years experience" },

            };
            var employeeStatus = new HrEmployeeStatus { Emps_Id = 2, Emps_Title = "Database administrator", Emps_Description = "B" };

            mockRepo.Setup(x => x.GetSingle(1)).Returns(employeeStatus);

            var allAccepted = logic.EmployeeLogic.GetUnExitedEmployees();

            Assert.NotNull(allAccepted);
        }

        /// <summary>
        /// Unexited employee list .
        /// </summary>
        [Test]
        public void RejectedEmployeesList()
        {
            using DataContext context = new DataContext();
            IBaseLogic logic = new BaseLogic(new BaseRepository(context));

            var exiteds = logic.EmployeeLogic.GetExitedEmployees();

            Assert.NotNull(exiteds);
        }

        /// <summary>
        /// Exited employee list .
        /// </summary>
        [Test]
        public void ListEmployeesCredentials()
        {
            using DataContext context = new DataContext();
            IBaseLogic logic = new BaseLogic(new BaseRepository(context));
            Mock<IEmployeCredentialsRepository> mockRepo = new Mock<IEmployeCredentialsRepository>();

            var employeesCredentials = new HrEmployeeCredentials { Empc_Employee_Id = 2, Empc_Id = 2, Empc_Mail = "james@yahoo.com", Empc_Password = "James1" };

            mockRepo.Setup(x => x.GetSingle(1)).Returns(employeesCredentials);

            var allCredentials = logic.EmployeCredentialsLogic.GetSingle(1);

            Assert.NotNull(allCredentials);
        }

        /// <summary>
        /// Create new employee.
        /// </summary>
        [Test]
        public void CreateEmployee()
        {
            using DataContext context = new DataContext();
            IBaseLogic logic = new BaseLogic(new BaseRepository(context));
            Mock<IBaseLogic> mockRepo = new Mock<IBaseLogic>();
            var employee = new HrEmployee
            {
                Emp_Name = "Sevinj",
                Emp_Surname = "Abdullayeva",
                Emp_Code = "11",
                Emp_Is_Existed = false,
            };

            mockRepo.Setup(x => x.EmployeeLogic.Create(employee));
            var result = logic.EmployeeLogic.Create(employee);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Create new employee.
        /// </summary>
        [Test]
        public void UpdateEmployee()
        {
            using DataContext context = new DataContext();
            IBaseLogic logic = new BaseLogic(new BaseRepository(context));
            Mock<IBaseLogic> mockRepo = new Mock<IBaseLogic>();
            HrEmployee employee = new HrEmployee
            {
                Emp_Name = "Sevinj",
                Emp_Surname = "Abdullayeva",
                Emp_Code = "11",
                Emp_Is_Existed = true,
            };

            mockRepo.Setup(x => x.EmployeeLogic.Edit(1, employee));

            var result = logic.EmployeeLogic.Edit(1, employee).Result;

            Assert.IsTrue(result);
        }
    }
}