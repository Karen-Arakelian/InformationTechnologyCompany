using System;

namespace InformationTechnologyCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine(CompanySimulationUtil.GenerateRandomFirstName(4));
            Console.WriteLine();
            Console.WriteLine(CompanySimulationUtil.GenerateRandomLastName(Ending.Arm,3));
            Console.WriteLine();
            Console.WriteLine(CompanySimulationUtil.GenerateRandomEmail(12));
            Console.WriteLine();
            Console.WriteLine(CompanySimulationUtil.GenerateRandomPhoneNumber(OperatorCode.VivaCell_1, PhoneNumberLength.Armenia));
            Console.WriteLine();
            CompanySimulationUtil.GenerateFutureEmployee();
            Console.WriteLine();*/
            CompanySimulationUtil.GenerateCompany("MyCompany").generateReport();




        }
    }
}
