using System;
using System.Collections.Generic;
using System.Text;

namespace InformationTechnologyCompany
{
    public class HumanResourseDepartment : Department
    {
        Employee director;
        string companyId;
        DepartmentName departmentName;
        Dictionary<string, Employee> allEmployeeDictionary = new Dictionary<string, Employee>();

        Dictionary<string, Employee> employeesPool = new Dictionary<string, Employee>();
        Dictionary<string, Team> teamPool = new Dictionary<string, Team>();
        Dictionary<string, Department> departmentPool = new Dictionary<string, Department>();
        Dictionary<string, Company> companyPool = new Dictionary<string, Company>();


        public HumanResourseDepartment(string companyId, DepartmentName departmentName) : base (DepartmentName.HR)
        {
            this.companyId = companyId;
            
        }
        public bool hrAuthority = Convert.ToBoolean(DepartmentName.HR);

        public void Hire(Team team, SpecialistType specialistType, QualificationLevel qualificationLevel,
            string personalId, string firstName, string lastName, string numberPhone, string email, DateTime birthDate)
        {
            if (hrAuthority)
            {
                Employee employee = new Employee(specialistType, qualificationLevel, personalId, firstName,
                    lastName, numberPhone, email, birthDate);
                team.AddEmployee(employee);
                //Hire(team, employee);
            }
            else
            {
                Console.WriteLine("Contact the HR department for that question");
            }
        }

        public void AddTeam(Team team)
        {
            team.DepartmentId = this.UnitId;
            this.AddMember(team, true);
        }

        public void Hire(Team team, Employee employee)
        {
            allEmployeeDictionary.Add(employee.EmployeeId, employee);
            team.AddEmployee(employee);
        }

        public void Fire(Employee employee, Team team) 
        {
            if (hrAuthority)
            {

                allEmployeeDictionary.Remove(employee.EmployeeId);
                team.RemoveEmployee(employee);
            }
            else
            {
                Console.WriteLine("Contact the HR department for that question");
            }
        }

        public void RemoveTeam(Team team)
        {
            team.DepartmentId = this.UnitId;
            this.RemoveMember(team, true);
        }
    }
}