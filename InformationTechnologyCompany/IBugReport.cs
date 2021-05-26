using System;
using System.Collections.Generic;
using System.Text;

namespace InformationTechnologyCompany
{
    public interface IBugReport
    {
        void Create(string createdById, string title, string description);
        void Update(string createdById, string title, string description);
    }
}
