using System;
using System.Security.Cryptography.X509Certificates;
using HR_CMS.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HR_CMS.Testing
{
    [TestClass]
    public class DataTesting
    {
        [TestMethod]
        public void TestPersonnel()
        {
            public Personnel TestEmployee1 = new Personnel()
            {
                PersonnelId = 1,
                FirstName = "John",
                LastName = "Smith",
                MiddleName = "Charles",
                SSN = 555667789,
                DOB = new DateTimeOffset(1980, 10, 31, 0, 0, 0, new TimeSpan(1, 0, 0)),
                DOH = new DateTimeOffset(DateTime.Now, new TimeSpan(1, 0, 0)),
                DOT = null,

            };

        }
    }
}
