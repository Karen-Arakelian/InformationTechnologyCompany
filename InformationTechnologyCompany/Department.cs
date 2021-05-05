using System;
using System.Collections.Generic;
using System.Text;

namespace InformationTechnologyCompany
{
    public enum DepartmentName
    {
        Undefined,
        Marketing,
        Finance,
        ProjectManagement,
        Development,
        QualityAssurance,
        HR
    }
    class Department : Unit<Team> //IHumanResourceDepartment
    {
        Employee director;
        string companyId;
        Dictionary<string, Employee> allEmployeeDictionary = new Dictionary<string, Employee>();

        public Department(DepartmentName departmentName, string companyId) : base(departmentName.ToString(), UnitType.Department)
        {
            this.companyId = companyId;
        }

        public Department(DepartmentName departmentName) : base(departmentName.ToString(), UnitType.Department)
        {

        }

        public Employee Director
        {
            get => director;
            set
            {
                director = value;
                this.Head = value;
            }
        }
        public string CompanyId { get => companyId; set => companyId = value; }

        public void AddTeam(Team team)
        {

            team.DepartmentId = this.UnitId;
            this.AddMember(team, true);
        }
   
        public void RemoveTeam(Team team)
        {
            team.DepartmentId = this.UnitId;
            this.RemoveMember(team, true);
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
    }
}