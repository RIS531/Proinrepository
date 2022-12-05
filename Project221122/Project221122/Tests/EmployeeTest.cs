using NUnit.Framework;
using OpenQA.Selenium;
using Project221122.Pages;
using Project221122.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project221122.Tests
{
    [TestFixture]
    [Parallelizable]
    public class EmployeeTest: Commondriver
    {


        [Test, Order(1)]
        public void CreateEmployeeTests()
        {
            //Homepage HomePageObj = new Homepage();
            //HomePageObj.gotoEmployeePage(driver);
            //EmployeePage EmpPgobj = new EmployeePage();
            //EmpPgobj.createEmployee(driver);
        }
        [Test, Order(2)]
        public void EditTest()
        {
            //Homepage HomePageObj = new Homepage();
            //HomePageObj.gotoEmployeePage(driver);
            //EmployeePage EmpEdPgobj = new EmployeePage();
            //EmpEdPgobj.EditEmployee(driver);

        }

        [Test, Order(3)]
        public void DeleteTest()
        {
            //Homepage HomePageObj = new Homepage();
            //HomePageObj.gotoEmployeePage(driver);
            //EmployeePage DelPageObj = new EmployeePage();
            //DelPageObj.deleteEmployee(driver);
        }




    }
}
