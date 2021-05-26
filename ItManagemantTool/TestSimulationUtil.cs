using System;
using System.Collections.Generic;
using System.Text;

namespace InformationTechnologyCompany
{
    public class TestSimulationUtil
    {        
        public static Employee GenerateFutureEmployee()
        {
            var rand = new Random();
            var qualificationLevelCount = Enum.GetNames(typeof(QualificationLevel)).Length;
            QualificationLevel qualificationLevel = (QualificationLevel)rand.Next(1, qualificationLevelCount + 1);
            var specialistTypeCount = Enum.GetNames(typeof(SpecialistType)).Length;
            SpecialistType specialistType = (SpecialistType)rand.Next(1, specialistTypeCount + 1);

            string firstName = TestUtil.GetRandomFirstName(6);
            string lastName = TestUtil.GetRandomLastName(4);
            string email = TestUtil.GetRandomEmail(10);
            string phoneNumber = TestUtil.GetRandomPhoneNumber();
            DateTime birthDate = TestUtil.GetDateOfBirth(18, 70);
            string personalId = TestUtil.getGuid();
            Employee employee = new Employee(specialistType, qualificationLevel, personalId, firstName, lastName, phoneNumber, email, birthDate);
            //Console.WriteLine(employee.ToString() + "\n");
            return employee;
        }

        public static List<Employee> GenerateFutureEmployeePool(uint futureEmployeeCount)
        {
            List<Employee> futureEmployeeList = new List<Employee>();
            for (uint i = 0; i < futureEmployeeCount; i++)
            {
                futureEmployeeList.Add(GenerateFutureEmployee());
            }
            return futureEmployeeList;   
        }

        public static Team GenerateTeam(string teamName)
        {
            Team team = new Team(teamName);
            team.Manager = GenerateFutureEmployee();
            team.AddEmployee(GenerateFutureEmployee());
            team.AddEmployee(GenerateFutureEmployee());
            team.AddEmployee(GenerateFutureEmployee());
            return team;
        }
        public static HumanResourseDepartment GenerateDepartment(DepartmentName departmentName)
            {
            // generate a department with two teams : team A, team B;
            var department = new HumanResourseDepartment("",departmentName);
            department.Director = GenerateFutureEmployee();
            department.AddTeam(GenerateTeam(departmentName + "Team A"));
            department.AddTeam(GenerateTeam(departmentName + "Team B"));
            return department;
            }

        public static Company GenerateCompany(string companyName)
        {
            // generate a company with four departments : HR, Finance, Development, QA
            Company company = new Company(companyName);
            company.ChiefExecutiveOfficer = GenerateFutureEmployee();
            company.AddDepartment(GenerateDepartment(DepartmentName.Development));
            company.AddDepartment(GenerateDepartment(DepartmentName.Finance));
            company.AddDepartment(GenerateDepartment(DepartmentName.Marketing));
            company.AddDepartment(GenerateDepartment(DepartmentName.QualityAssurance));
            return company;
        }

        
    }
}
