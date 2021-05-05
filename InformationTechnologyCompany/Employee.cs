using System;
using System.Collections.Generic;
using System.Text;

namespace InformationTechnologyCompany
{
    public enum QualificationLevel
    {
          Undefined,
          Intern,
          EntryLevel,
          Junior,
          Intermediate,
          Senior,
          Director,
          ChiefExecutiveOfficer
    }
    public enum SpecialistType
    {
        Undefined,
        HumanResourceSpecialist,
        FinancilSpecialist,
        SoftwareEngineer,
        QualityAssurenceEngineer,
        ProjectManagementSpecialist,
        MarketingingSpecialist
    }
    class Employee : Person, IReportability
    {
        string employeeId = CompanyUtil.getGuid();
        string companyId = "";
        string departmentId = "";
        string teamId = "";
        QualificationLevel qualificationLevel;
        SpecialistType specialistType = SpecialistType.Undefined;
        DateTime startDate = DateTime.UtcNow;
        DateTime updateDate;
        DateTime endDate;
        uint salary;

        //Constructors
        public Employee(string companyId, string teamId, string departmentId, SpecialistType specialistType,
            QualificationLevel qualificationLevel, uint salary,
            string personalId, string firstName, string lastName, string phoneNumber, string email, DateTime birthDate)
            : base(specialistType, personalId, firstName, lastName, phoneNumber, email, birthDate)

        {
            this.companyId = companyId;
            this.departmentId = departmentId;
            this.teamId = teamId;
            this.qualificationLevel = qualificationLevel;
            this.specialistType = specialistType;
            this.salary = salary;
        }

        // Prospective(candidate) employee
        public Employee(SpecialistType specialistType,
            QualificationLevel qualificationLevel,
            string personalId, string firstName, string lastName, string phoneNumber, string email, DateTime birthDate)
            : base(specialistType, personalId, firstName, lastName, phoneNumber, email, birthDate)
        {

            this.qualificationLevel = qualificationLevel;
            this.specialistType = specialistType;
        }

        public string EmployeeId { get => employeeId; }
        public string CompanyId { get => companyId; set => companyId = value; }
        public string DepartmentId { get => departmentId; set => departmentId = value; }
        public string TeamId { get => teamId; set => teamId = value; }
        public QualificationLevel QualificationLevel 
        { get => qualificationLevel; set => qualificationLevel = value; }
        public SpecialistType SpecialistType { get => specialistType; set => specialistType = value; }
        public DateTime StartDate { get => startDate; }
        public DateTime UpdateDate { get => updateDate; set => updateDate = value; }
        public DateTime EndDate { get => endDate; set => endDate = value; }
        public uint Salary { get => salary; set => salary = value; }

        // Methods
        override
        public string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("first name = {0}, last name = {1}, " + 
                "phone number = {2}, email = {3}, " +
                "birthdate = {4}, personal id = {5}, qualification = {6} {7}",
                this.FirstName, this.LastName,this.PhoneNumber, this.Email, this.BirthDate, this.PersonalId, this.qualificationLevel, this.specialistType);
            return stringBuilder.ToString();
        }

        public void generateReport()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
