namespace HR_CMS.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Security.Cryptography;
    using System.Security.Cryptography.X509Certificates;

    internal sealed class Configuration : DbMigrationsConfiguration<HR_CMS.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "HR_CMS.Data.ApplicationDbContext";
        }

        protected override void Seed(HR_CMS.Data.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //Seed Depts
/*            context.DeptDbSet.AddOrUpdate(x => x.DeptId,
                new Dept()
                {
                    DeptId = 1,
                    DeptName = "Human Resources",
                },

                new Dept()
                {
                    DeptId = 2,
                    DeptName = "Sales",
                },

                new Dept()
                {
                    DeptId = 3,
                    DeptName = "Marketing",
                },

                new Dept()
                {
                    DeptId = 4,
                    DeptName = "Research & Development",
                },

                new Dept()
                {
                    DeptId = 5,
                    DeptName = "Compliance",
                }
            );
            //Seed Positions
            context.PositionDbSet.AddOrUpdate(x => x.PositionId,

                new Position()
                {
                    PositionId = 1,
                    DeptId = 1,
                    PositionTitle = "Executive Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = true
                },
                new Position()
                {
                    PositionId = 2,
                    DeptId = 1,
                    PositionTitle = "Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 3,
                    DeptId = 1,
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 4,
                    DeptId = 1,
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 5,
                    DeptId = 2,
                    PositionTitle = "Executive Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = true
                },
                new Position()
                {
                    PositionId = 6,
                    DeptId = 2,
                    PositionTitle = "Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 7,
                    DeptId = 2,
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 8,
                    DeptId = 2,
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 9,
                    DeptId = 2,
                    PositionTitle = "Temp. Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 10,
                    DeptId = 3,
                    PositionTitle = "Executive Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = true
                },
                new Position()
                {
                    PositionId = 11,
                    DeptId = 3,
                    PositionTitle = "Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 12,
                    DeptId = 3,
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 13,
                    DeptId = 3,
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 14,
                    DeptId = 4,
                    PositionTitle = "Executive Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = true
                },
                new Position()
                {
                    PositionId = 15,
                    DeptId = 4,
                    PositionTitle = "Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 16,
                    DeptId = 4,
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 17,
                    DeptId = 4,
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 18,
                    DeptId = 5,
                    PositionTitle = "Executive Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = true
                },
                new Position()
                {
                    PositionId = 19,
                    DeptId = 5,
                    PositionTitle = "Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 20,
                    DeptId = 5,
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                new Position()
                {
                    PositionId = 21,
                    DeptId = 5,
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                }
            );
            //Seed Personnel
            context.PersonnelDbSet.AddOrUpdate(x => x.PersonnelId,
                new Personnel()
                {
                    PersonnelId = 1,
                    FirstName = "Tammy",
                    LastName = "Winslow",
                    MiddleName = "Christine",
                    SSN = "431-90-2134",
                    DOB = new DateTime(1973, 09, 08),
                    DOH = new DateTime(2005, 07, 13),
                    DOT = null
                },
                new Personnel()
                {
                    PersonnelId = 2,
                    FirstName = "Cassidy",
                    LastName = "Pfannerstill",
                    MiddleName = "Kyle",
                    SSN = "003-36-2848",
                    DOB = new DateTime(1981, 09, 21),
                    DOH = new DateTime(2011, 02, 19),
                    DOT = null
                },
                new Personnel()
                {
                    PersonnelId = 3,
                    FirstName = "Jeffrey",
                    LastName = "Shields",
                    MiddleName = "Steven",
                    SSN = "004-82-9269",
                    DOB = new DateTime(1986, 06, 27),
                    DOH = new DateTime(2017, 11, 06),
                    DOT = null
                },
                new Personnel()
                {
                    PersonnelId = 4,
                    FirstName = "Percival",
                    LastName = "Champlin",
                    SSN = "217-90-1548",
                    DOB = new DateTime(1978, 01, 04),
                    DOH = new DateTime(1999, 03, 07),
                    DOT = new DateTime(2019, 05, 27)
                },
                new Personnel()
                {
                    PersonnelId = 5,
                    FirstName = "Kailyn",
                    LastName = "Douglas",
                    MiddleName = "Celine",
                    SSN = "221-30-6362",
                    DOB = new DateTime(1998, 10, 31),
                    DOH = new DateTime(2020, 10, 08),
                    DOT = null
                },
                new Personnel()
                {
                    PersonnelId = 6,
                    FirstName = "Ellis",
                    LastName = "Reinger",
                    MiddleName = "Archibald",
                    SSN = "528-29-0168",
                    DOB = new DateTime(1985, 04, 02),
                    DOH = new DateTime(2019, 06, 18),
                    DOT = new DateTime(2019, 07, 19)
                },
                new Personnel()
                {
                    PersonnelId = 7,
                    FirstName = "Su Lin",
                    LastName = "Park",
                    SSN = "502-35-6860",
                    DOB = new DateTime(1971, 11, 08),
                    DOH = new DateTime(1992, 08, 01),
                    DOT = null
                },
                new Personnel()
                {
                    PersonnelId = 8,
                    FirstName = "Mackenzie",
                    LastName = "Lairmore",
                    MiddleName = "Joseph",
                    SSN = "166-28-6107",
                    DOB = new DateTime(1989, 03, 11),
                    DOH = new DateTime(2009, 07, 11),
                    DOT = new DateTime(2019, 06, 02)
                },
                new Personnel()
                {
                    PersonnelId = 9,
                    FirstName = "Ralph",
                    LastName = "Kirlin",
                    MiddleName = "Oriole",
                    SSN = "520-06-9301",
                    DOB = new DateTime(1993, 04, 07),
                    DOH = new DateTime(2014, 04, 15),
                    DOT = null
                },
                new Personnel()
                {
                    PersonnelId = 10,
                    FirstName = "Katarina",
                    LastName = "Mwanza",
                    SSN = "587-80-1954",
                    DOB = new DateTime(2001, 03, 17),
                    DOH = DateTime.Now.Subtract(TimeSpan.FromDays(34)),
                    DOT = null
                }
            );
            context.ContactDbSet.AddOrUpdate(x => x.ContactId,
                new Contact()
                {
                    ContactId = 1,
                    PersonnelId = 1,
                    PhoneNumber = "(883)555-0421",
                    Email = "workerbee411@email.net",
                    Address = "1911 Colton Ave"
                },
                new Contact()
                {
                    ContactId = 2,
                    PersonnelId = 2,
                    PhoneNumber = "(883)555-0422",
                    Email = "workerbee311@email.net",
                    Address = "111 Golden Ave"
                },
                new Contact()
                {
                    ContactId = 3,
                    PersonnelId = 3,
                    PhoneNumber = "(883)555-0423",
                    Email = "workerbee211@email.net",
                    Address = "211 Golden Ave"
                },
                new Contact()
                {
                    ContactId = 4,
                    PersonnelId = 4,
                    PhoneNumber = "(883)555-0424",
                    Email = "workerbee11@email.net",
                    Address = "202 Forensic Drive"
                },
                new Contact()
                {
                    ContactId = 5,
                    PersonnelId = 5,
                    PhoneNumber = "(883)555-0421",
                    Email = "workerbee511@email.net",
                    Address = "2503 Colton Ave"
                },
                new Contact()
                {
                    ContactId = 6,
                    PersonnelId = 6,
                    PhoneNumber = "(883)555-0523",
                    Email = "workerbee611@email.net",
                    Address = "3713 Broadridge Way"
                },
                new Contact()
                {
                    ContactId = 7,
                    PersonnelId = 7,
                    PhoneNumber = "(883)555-8971",
                    Email = "workerbee31@email.net",
                    Address = "25 Cottage Circle"
                },
                new Contact()
                {
                    ContactId = 8,
                    PersonnelId = 8,
                    PhoneNumber = "(883)555-1143",
                    Email = "workerbee271@email.net",
                    Address = "37005 Carlton Cove Parkway"
                },
                new Contact()
                {
                    ContactId = 9,
                    PersonnelId = 9,
                    PhoneNumber = "(883)555-2123",
                    Email = "workerbee411@email.net",
                    Address = "3498 Chicago Rd"
                },
                new Contact()
                {
                    ContactId = 10,
                    PersonnelId = 10,
                    PhoneNumber = "(883)555-0421",
                    Email = "elvis.is.life@elvisfans.net",
                    Address = "205 Memphis Rd"
                }
            );
            context.WorkInfoDbSet.AddOrUpdate(x => x.WorkInfoId,
                new WorkInfo()
                {
                    WorkInfoId = 1,
                    ContactId = 1,
                    PersonnelId = 1,
                    PositionId = 1,
                    Wage = 65000,
                    WorkEmail = "firstname.lastname@company.com"
                }
            );
*/        }
    }
}
