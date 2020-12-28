using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechJobsOO;


namespace TechJobsTests
{
    [TestClass]
    public class JobTests 
    {
        private const string Name = "Product Tester";

        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.AreEqual(1, job2.Id - job1.Id,0.001);

        }
        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Dessert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product Tester", job1.Name);
            Assert.AreEqual("ACME", job1.EmployerName.Value);
            Assert.AreEqual("Dessert", job1.EmployerLocation.Value);
            Assert.AreEqual("Quality Control", job1.JobType.Value); 
            Assert.AreEqual("Persistence", job1.JobCoreCompetency.Value);
        }
        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Dessert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product Tester", new Employer("ACME"), new Location("Dessert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1 == job2);
        }
        // When passed a Job object, it should return a string that contains a blank line before and after the job information,
         //The string should contain a label for each field, followed by the data stored in that field. Each field should be on its own line (I tested step 1 and 2)
        [TestMethod]
        public void TestJobToString()
        {
           Job job1 = new Job("Product Tester", new Employer("ACME"), new Location("Dessert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
           var actual = job1.ToString();
           var expected = "\nID: 1\nName: Product Tester\nEmployer: ACME\nLocation: Dessert\nPosition Type: Quality Control\nCore Competency: Persistence\n";
            Assert.AreEqual(expected, actual);
        }
   

        //If a field is empty, the method should add, “Data not available” after the label.
        [TestMethod]
   
        public void TestFieldEmpty()
        {
            Job job1 = new Job(" ", new Employer(" "), new Location(" "), new PositionType(" "), new CoreCompetency(" "));
            var actual = job1.ToString();
            var expected = "OOPS! This job does not seem to exist.";
            Assert.AreEqual(expected, actual);
        }
    }
}
