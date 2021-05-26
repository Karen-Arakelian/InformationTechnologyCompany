using System;
using System.Collections.Generic;
using System.Text;

namespace InformationTechnologyCompany
{
    public enum BugStatus
    {
        New,
        Assigned,
        Fixed,
        Verified,
        ClosedAsDuplicate,
        ClosedAsReproducible,
        ClosedObsolete
    }
    public class BugReport
    {
        string bugId= CompanyUtil.getGuid();
        DateTime timestamp = DateTime.UtcNow;
        string title;
        string description;
        string createdById;
        string assignedToId = " ";
        BugStatus status = BugStatus.New;
        

        public BugReport(string createdById, string title, string description)
        {
            this.createdById = createdById;
            this.title = title;
            this.description = description;
        }

        public string BugId { get => bugId; set => bugId = value; }
        public DateTime Timestamp { get => timestamp; set => timestamp = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public string CreatedById { get => createdById; set => createdById = value; }
        public string AssignedToId { get => assignedToId; set => assignedToId = value; }
        public BugStatus Status { get => status; set => status = value; }
    }
}
