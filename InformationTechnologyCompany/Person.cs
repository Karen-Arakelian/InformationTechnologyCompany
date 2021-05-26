using System;
using System.Collections.Generic;
using System.Text;

namespace InformationTechnologyCompany
{
    public class Person 
    {
        string personalId;
        DateTime birthDate;
        DateTime deceasedDate;
        SpecialistType specialistType;

        string firstName;
        string lastName;
        string email;
        string phoneNumber;
        public Person(SpecialistType specialistType, string personalId, string firstName, string lastName,
            string phoneNumber, string email, DateTime birthDate)
        {
            this.specialistType = SpecialistType;
            this.personalId = personalId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.email = email;
            this.phoneNumber = phoneNumber;
        }

        public string PersonalId { get => personalId; }
        public DateTime BirthDate { get => birthDate; }
        public DateTime DeceasedDate { get => deceasedDate; set => deceasedDate = value; }
        public string FirstName { get => firstName; }
        public string LastName { get => lastName; }
        public string Email { get => email; set => email = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public SpecialistType SpecialistType { get => specialistType; set => specialistType = value; }
    }
}
