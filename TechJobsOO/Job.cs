using System;
using System.Collections.Generic;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        public Job()
        {
            Id = nextId;
            nextId++;
        }
         public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompeytency) : this()
        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompeytency;
            
        }

        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
                 
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
        public override string ToString()
        {
            string dNoAvailable = "Data not Avalaible";
            string stringLineBlank = "";
            if ((Name == null || Name.ToString().Trim() == "")
                && (EmployerName == null || EmployerName.ToString().Trim() == "")
                && (EmployerLocation == null || EmployerLocation.ToString().Trim() == "")
                && (JobType == null || JobType.ToString().Trim() == "")
                && (JobCoreCompetency == null || JobCoreCompetency.ToString().Trim() == "")) 
            {
                return "OOPS! This job does not seem to exist.";
            }
            stringLineBlank += "ID: " + Id + "\n";
            if (Name == null || Name.Trim() == "")
            {
                stringLineBlank += "Name: " + dNoAvailable + "\n";
            }
            else
            {
                stringLineBlank += "Name: " + Name + "\n";
            }


            if (EmployerName == null || EmployerName.ToString().Trim() == "")
            {
                stringLineBlank += "Employer: " + dNoAvailable + "\n";
            }
            else
            {
                stringLineBlank += "Employer: " + EmployerName.ToString().Trim() + "\n";
            }



            if (EmployerLocation == null || EmployerLocation.ToString().Trim() == "")
            {
                stringLineBlank += "Location: " + dNoAvailable + "\n";
            }
            else
            {
                stringLineBlank += "Location: " + EmployerLocation.ToString().Trim() + "\n";
            }


            if (JobType == null || JobType.ToString().Trim() == "")
            {
                stringLineBlank += "Position Type: " + dNoAvailable + "\n";
            }
            else
            {
                stringLineBlank += "Position Type: " + JobType.ToString().Trim() + "\n";
            }


            if (JobCoreCompetency == null || JobCoreCompetency.ToString().Trim() == "")
            {
                stringLineBlank += "Core Competency: " + dNoAvailable + "\n";
            }
            else
            {
                stringLineBlank += "Core Competency: " + JobCoreCompetency.ToString().Trim() + "\n";
            }
            return stringLineBlank;


        }

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}
