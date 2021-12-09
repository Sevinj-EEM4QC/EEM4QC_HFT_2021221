//using EEM4QC_HFT_2021221.Models;
//using EEM4QC_HFT_2021221.Repository;

//using Moq;
//using NUnit.framework;
//using System;
//using System.collections.generic;
//using System.linq;
//using System.text;
//using System.threading.tasks;
//using System.Collections.Generic;

//namespace eem4qc_hft_2021221.test
//{
//    public class noncrudtests
//    {
//        private Mock<IEmployeeRepository> hrEmployee;

//        private Mock<ISalaryRecordRepository> salaryRecord;

//        // <summary>
//        // creaing the logic with mocks.
//        // </summary>
//        // <returns>reception.</returns>
//        public HrEmployee createlogicwithmocks()
//        {
//            this.hrEmployee = new Mock<IEmployeeRepository>();
//            this.salaryRecord = new Mock<ISalaryRecordRepository>();
//            List<HrEmployee> people = new List<HrEmployee>() {
//              new HrEmployee { Emp_Name = "Sevinj", Emp_Id = 1, Emp_Is_Existed = true, Emp_Surname = "Abdullayeva" },
//                   new HrEmployee { Emp_Name = "James", Emp_Id = 2, Emp_Is_Existed = true, Emp_Surname = "Bond" },
//                   new HrEmployee { Emp_Name = "Ilkin", Emp_Id = 3, Emp_Is_Existed = true, Emp_Surname = "Mammad" },
//                   new HrEmployee { Emp_Name = "Zeynab", Emp_Id = 4, Emp_Is_Existed = true, Emp_Surname = "Rahim" },
//                   new HrEmployee { Emp_Name = "Oktay", Emp_Id = 5, Emp_Is_Existed = true, Emp_Surname = "Mammadov" },
//                   new HrEmployee { Emp_Name = "Buse", Emp_Id = 6, Emp_Is_Existed = true, Emp_Surname = "Su" },
//                   new HrEmployee { Emp_Name = "Altay", Emp_Id = 7, Emp_Is_Existed = true, Emp_Surname = "Aliyev" },
//                   new HrEmployee { Emp_Name = "Olive", Emp_Id = 8, Emp_Is_Existed = true, Emp_Surname = "Mah" },
//                   new HrEmployee { Emp_Name = "Tommy", Emp_Id = 9, Emp_Is_Existed = true, Emp_Surname = "Tomson" },
//                   new HrEmployee { Emp_Name = "Saleh", Emp_Id = 10, Emp_Is_Existed = true, Emp_Surname = "Terim" },
//            };

//            List<SalaryRecordRepository> extra = new List<SalaryRecordRepository>()
//                {
//                  new extra() { id = 1234, extratype = "excursion", extraprice = 140, extradays = "monday", extranrpeople = 30, extraticket = "yes" },
//                  new extra() { id = 1232, extratype = "parachute", extraprice = 90, extradays = "every day", extranrpeople = 2, extraticket = "yes" },
//                  new extra() { id = 1237, extratype = "banana", extraprice = 50, extradays = "every day", extranrpeople = 7, extraticket = "yes" },
//                  new extra() { id = 1231, extratype = "muzeum", extraprice = 10, extradays = "sunday", extranrpeople = 100, extraticket = "yes" },
//                  new extra() { id = 1238, extratype = "night excursion", extraprice = 10, extradays = "wednesday", extranrpeople = 40, extraticket = "yes" },
//                };

//            list<rooms> rooms = new list<rooms>()
//                {
//                    new rooms() { id = 111, roomstype = "double", roomsamount = 10, roomsavailable = 8, roomsprice = 240, roomsview = "seaside" },
//                    new rooms() { id = 112, roomstype = "triple", roomsamount = 15, roomsavailable = 11, roomsprice = 300, roomsview = "pool" },
//                    new rooms() { id = 114, roomstype = "twin", roomsamount = 7, roomsavailable = 4, roomsprice = 475, roomsview = "aqua-park" },
//                };

//            this.expectedresulttotal = new list<totalprice>()
//                {
//                    new totalprice() { name = "john", extra = "excursion", room = "double", price = 380 },
//                    new totalprice() { name = "dean", extra = "parachute", room = "triple", price = 390 },
//                    new totalprice() { name = "jake", extra = "banana", room = "twin", price = 525 },
//                    new totalprice() { name = "drake", extra = "muzeum", room = "triple", price = 310 },
//                    new totalprice() { name = "alfred", extra = "night excursion", room = "twin", price = 485 },
//                };

//            this.expectedresultroomnr = new list<roomnr>()
//                {
//                    new roomnr { roomtype = "double", nr = 1 },
//                    new roomnr { roomtype = "triple", nr = 2 },
//                    new roomnr { roomtype = "twin", nr = 2 },
//                };

//            this.extraresultextranumber = new list<extranumber>()
//                {
//                    new extranumber() { extra = "excursion", nr = 1 },
//                    new extranumber() { extra = "parachute", nr = 1 },
//                    new extranumber() { extra = "banana", nr = 1 },
//                    new extranumber() { extra = "muzeum", nr = 1 },
//                    new extranumber() { extra = "night excursion", nr = 1 },
//                };

//            this.extrarepo.setup(repo => repo.getall()).returns(extra.asqueryable());
//            this.peoplerepo.setup(repo => repo.getall()).returns(people.asqueryable());
//            this.roomrepo.setup(repo => repo.getall()).returns(rooms.asqueryable());

//            return new reception(this.extrarepo.object, this.peoplerepo.object, this.roomrepo.object);
//        }

//            / <summary>
//            / testing the non-crud operation of how many people pay for their holiday.
//            / </summary>
//            [test]
//            public void testtotalprice()
//        {
//            var logic = this.createlogicwithmocks();

//            var totalprice = logic.totalprice();

//            assert.that(totalprice, is.equivalentto(this.expectedresulttotal));
//            assert.that(totalprice.count(), is.equalto(5));
//            assert.that(totalprice.count(), is.greaterthan(0));

//            this.extrarepo.verify(repo => repo.getall(), times.once);
//            this.peoplerepo.verify(repo => repo.getall(), times.once);
//            this.roomrepo.verify(repo => repo.getall(), times.once);
//        }

//        /// <summary>
//        /// testing the non-crud operation of how many room of each type are used.
//        /// </summary>
//        [test]
//        public void roomnr()
//        {
//            var logic = this.createlogicwithmocks();

//            var roomnr = logic.roomnr();

//            assert.that(roomnr.count(), is.equalto(3));
//            assert.that(roomnr, is.equivalentto(this.expectedresultroomnr));

//            this.extrarepo.verify(repo => repo.getall(), times.never);
//            this.peoplerepo.verify(repo => repo.getall(), times.once);
//            this.roomrepo.verify(repo => repo.getall(), times.once);
//        }

//        /// <summary>
//        /// testing the non-crud operation of how many extra activity are picked by people.
//        /// </summary>
//        [test]
//        public void peopleextra()
//        {
//            var logic = this.createlogicwithmocks();

//            var extranr = logic.extranumber();

//            assert.that(extranr.count(), is.equalto(5));
//            assert.that(extranr, is.equivalentto(this.extraresultextranumber));

//            this.extrarepo.verify(repo => repo.getall(), times.once);
//            this.peoplerepo.verify(repo => repo.getall(), times.once);
//            this.roomrepo.verify(repo => repo.getall(), times.never);
//        }
//    }
//}
