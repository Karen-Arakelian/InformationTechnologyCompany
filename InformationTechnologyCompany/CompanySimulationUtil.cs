using System;
using System.Collections.Generic;
using System.Text;

namespace InformationTechnologyCompany
{
    public class CompanySimulationUtil
    {
        
        public static Employee GenerateFutureEmployee()
        {
            var rand = new Random();
            var qualificationLevelCount = Enum.GetNames(typeof(QualificationLevel)).Length;
            QualificationLevel qualificationLevel = (QualificationLevel)rand.Next(1, qualificationLevelCount + 1);
            var specialistTypeCount = Enum.GetNames(typeof(SpecialistType)).Length;
            SpecialistType specialistType = (SpecialistType)rand.Next(1, specialistTypeCount + 1);

            string firstName = CompanyUtil.GetRandomFirstName(6);
            string lastName = CompanyUtil.GetRandomLastName(4);
            string email = CompanyUtil.GetRandomEmail(10);
            string phoneNumber = CompanyUtil.GetRandomPhoneNumber();
            DateTime birthDate = CompanyUtil.GetDateOfBirth(18, 70);
            string personalId = CompanyUtil.getGuid();
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

        
    }
}
