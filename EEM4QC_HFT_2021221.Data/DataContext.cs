using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;
using Microsoft.EntityFrameworkCore;
using EEM4QC_HFT_2021221.Models;

namespace EEM4QC_HFT_2021221.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext>options)
            : base(options)
        {

        }

        public DataContext()
        {

        }

        public virtual DbSet<HrEmployee> Hr_Employees { get; set; }

        public virtual DbSet<HrEmployeeCredentials> Hr_Employee_Credentials { get; set; }

        public virtual DbSet<HrEmployeeExitDetail> Hr_Employee_Exit_Detail { get; set; }

        public virtual DbSet<HrEmployeeSalaryRecord> Hr_Employee_Salary_Record { get; set; }

        public virtual DbSet<HrEmployeeStatus> Hr_Employee_Status { get; set; }

        public virtual DbSet<UnExitedEmployeeModel> UnExited_Employee_Model { get; set; }

        public virtual DbSet<ExitedEmployeeModel> Exited_Employee_Model { get; set; }

        public virtual DbSet<HrEmployeeWorkDetails> Hr_Employee_Work_Details { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\db.mdf;Trusted_Connection=Yes;");
            }
            base.OnConfiguring(optionsBuilder);
        }
    }
}
