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
            //REMOVE THIS TO ACCESS SEED DATA
            return;
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            //Seed Depts
            var vDays = 1.5;
            var pDays = .5;
            var sDays = .5;
            context.DeptDbSet.AddOrUpdate(x => x.DeptId,
                //Human Resources
                new Dept()
                {
                    DeptId = 1,
                    DeptName = "Human Resources",
                },
                //Sales
                new Dept()
                {
                    DeptId = 2,
                    DeptName = "Sales",
                },
                //Marketing
                new Dept() 
                {
                    DeptId = 3,
                    DeptName = "Marketing",
                },
                // R&D
                new Dept() 
                {
                    DeptId = 4,
                    DeptName = "Research & Development",
                },
                // Compliance
                new Dept() 
                {
                    DeptId = 5,
                    DeptName = "Compliance",
                }
            );
            //Seed Positions
            context.PositionDbSet.AddOrUpdate(x => x.PositionId,
                //HR Executive Director
                new Position()
                {
                    PositionId = 1,
                    DeptId = 1,
                    PositionTitle = "Executive Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = true
                },
                //HR Director
                new Position()
                {
                    PositionId = 2,
                    DeptId = 1,
                    PositionTitle = "Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = false
                },
                //HR Supervisor
                new Position()
                {
                    PositionId = 3,
                    DeptId = 1,
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                //HR Associate
                new Position()
                {
                    PositionId = 4,
                    DeptId = 1,
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Sales Executive Director
                new Position()
                {
                    PositionId = 5,
                    DeptId = 2,
                    PositionTitle = "Executive Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = true
                },
                //Sales Director
                new Position()
                {
                    PositionId = 6,
                    DeptId = 2,
                    PositionTitle = "Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = false
                },
                //Sales Supervisor
                new Position()
                {
                    PositionId = 7,
                    DeptId = 2,
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Sales Associate
                new Position()
                {
                    PositionId = 8,
                    DeptId = 2,
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Sales Associate, Temp.
                new Position()
                {
                    PositionId = 9,
                    DeptId = 2,
                    PositionTitle = "Temp. Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Marketing Executive Director
                new Position()
                {
                    PositionId = 10,
                    DeptId = 3,
                    PositionTitle = "Executive Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = true
                },
                //Marketing Director
                new Position()
                {
                    PositionId = 11,
                    DeptId = 3,
                    PositionTitle = "Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = false
                },
                //Marketing Supervisor
                new Position()
                {
                    PositionId = 12,
                    DeptId = 3,
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Marketing Associate
                new Position()
                {
                    PositionId = 13,
                    DeptId = 3,
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                //R&D Executive Director
                new Position()
                {
                    PositionId = 14,
                    DeptId = 4,
                    PositionTitle = "Executive Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = true
                },
                //R&D Director
                new Position()
                {
                    PositionId = 15,
                    DeptId = 4,
                    PositionTitle = "Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = false
                },
                //R&D Supervisor
                new Position()
                {
                    PositionId = 16,
                    DeptId = 4,
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                //R&D Associate
                new Position()
                {
                    PositionId = 17,
                    DeptId = 4,
                    PositionTitle = "Associate",
                    IsSupervisor = false,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Compliance Executive Director
                new Position()
                {
                    PositionId = 18,
                    DeptId = 5,
                    PositionTitle = "Executive Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = true
                },
                //Compliance Director
                new Position()
                {
                    PositionId = 19,
                    DeptId = 5,
                    PositionTitle = "Director",
                    IsSupervisor = true,
                    IsDirector = true,
                    IsExecutive = false
                },
                //Compliance Supervisor
                new Position()
                {
                    PositionId = 20,
                    DeptId = 5,
                    PositionTitle = "Supervisor",
                    IsSupervisor = true,
                    IsDirector = false,
                    IsExecutive = false
                },
                //Compliance Associate
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
                //1: Tammy Winslow, Marketing Director
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
                //2: Cassidy Pfannerstill, Sales Director
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
                //3: Jeff Shields, R&D Supervisor
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
                //4: Percy Champlin, R&D Executive Director
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
                //5: Kailyn Douglas, R&D Director
                new Personnel()
                {
                    PersonnelId = 5,
                    FirstName = "Kailyn",
                    LastName = "Douglas",
                    MiddleName = "Celine",
                    SSN = "221-30-6362",
                    DOB = new DateTime(1998, 10, 31),
                    DOH = DateTime.Now.Subtract(TimeSpan.FromDays(67)),
                    DOT = null
                },
                //6: Ellis Reinger, Sales Associate
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
                //7: Su Lin Park, HR Executive Director
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
                //8: Mackenzie Lairmore, Compliance Associate
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
                //9: Ralph Kirlin, Compliance Supervisor
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
                //10: Kat Mwanza, Sales Associate (Temp)
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
            //Seed Contact
            context.ContactDbSet.AddOrUpdate(x => x.ContactId,
                //1: Tammy Winslow, Marketing Director
                new Contact()
                {
                    ContactId = 1,
                    PersonnelId = 1,
                    PhoneNumber = "(883)555-0421",
                    Email = "workerbee411@email.net",
                    Address = "1911 Colton Ave"
                },
                //2: Cassidy Pfannerstill, Sales Director
                new Contact()
                {
                    ContactId = 2,
                    PersonnelId = 2,
                    PhoneNumber = "(883)555-0422",
                    Email = "workerbee311@email.net",
                    Address = "111 Golden Ave"
                },
                //3: Jeff Shields, R&D Supervisor
                new Contact()
                {
                    ContactId = 3,
                    PersonnelId = 3,
                    PhoneNumber = "(883)555-0423",
                    Email = "workerbee211@email.net",
                    Address = "211 Golden Ave"
                },
                //4: Percy Champlin, R&D Executive Director
                new Contact()
                {
                    ContactId = 4,
                    PersonnelId = 4,
                    PhoneNumber = "(883)555-0424",
                    Email = "workerbee11@email.net",
                    Address = "202 Forensic Drive"
                },
                //5: Kailyn Douglas, R&D Director
                new Contact()
                {
                    ContactId = 5,
                    PersonnelId = 5,
                    PhoneNumber = "(883)555-0421",
                    Email = "workerbee511@email.net",
                    Address = "2503 Colton Ave"
                },
                //6: Ellis Reinger, Sales Associate
                new Contact()
                {
                    ContactId = 6,
                    PersonnelId = 6,
                    PhoneNumber = "(883)555-0523",
                    Email = "workerbee611@email.net",
                    Address = "3713 Broadridge Way"
                },
                //7: Su Lin Park, HR Executive Director
                new Contact()
                {
                    ContactId = 7,
                    PersonnelId = 7,
                    PhoneNumber = "(883)555-8971",
                    Email = "workerbee31@email.net",
                    Address = "25 Cottage Circle"
                },
                //8: Mackenzie Lairmore, Compliance Associate
                new Contact()
                {
                    ContactId = 8,
                    PersonnelId = 8,
                    PhoneNumber = "(883)555-1143",
                    Email = "workerbee271@email.net",
                    Address = "37005 Carlton Cove Parkway"
                },
                //9: Ralph Kirlin, Compliance Supervisor
                new Contact()
                {
                    ContactId = 9,
                    PersonnelId = 9,
                    PhoneNumber = "(883)555-2123",
                    Email = "workerbee411@email.net",
                    Address = "3498 Chicago Rd"
                },
                //10: Kat Mwanza, Sales Associate (Temp)
                new Contact()
                {
                    ContactId = 10,
                    PersonnelId = 10,
                    PhoneNumber = "(883)555-0421",
                    Email = "elvis.is.life@elvisfans.net",
                    Address = "205 Memphis Rd"
                }
            );
            //Seed WorkInfo
            context.WorkInfoDbSet.AddOrUpdate(x => x.WorkInfoId,
                //1: Tammy Winslow, Marketing Director
                new WorkInfo()
                {
                    WorkInfoId = 1,
                    ContactId = 1,
                    PersonnelId = 1,
                    PositionId = 11,
                    Wage = 75000,
                    WorkEmail = "tammy.winslow@company.com",
                    HasBenefits = true,
                    StartOfBenefits = context.PersonnelDbSet.Find(1).DOH.AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(75)),
                    VacationDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * vDays,
                    PersonalDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * pDays,
                    SickDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 30,
                    PersonalDaysUsedLifetime = 5,
                    SickDaysUsedLifetime = 7,
                    VacationDaysUsedForPeriod = 4,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 1
                },
                //2: Cassidy Pfannerstill, Sales Director
                new WorkInfo()
                {
                    WorkInfoId = 2,
                    ContactId = 2,
                    PersonnelId = 2,
                    PositionId = 6,
                    Wage = 89000,
                    WorkEmail = "cassidy.pfannerstill@company.com",
                    HasBenefits = true,
                    StartOfBenefits = context.PersonnelDbSet.Find(2).DOH.AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(33)),
                    VacationDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(2).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * vDays,
                    PersonalDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(2).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * pDays,
                    SickDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(2).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 55,
                    PersonalDaysUsedLifetime = 11,
                    SickDaysUsedLifetime = 1,
                    VacationDaysUsedForPeriod = 15,
                    PersonalDaysUsedForPeriod = 3,
                    SickDaysUsedForPeriod = 0

                },
                //3: Jeff Shields, R&D Supervisor
                new WorkInfo()
                {
                    WorkInfoId = 3,
                    ContactId = 3,
                    PersonnelId = 3,
                    PositionId = 16,
                    Wage = 61000,
                    WorkEmail = "jeff.shields@company.com",
                    HasBenefits = true,
                    StartOfBenefits = context.PersonnelDbSet.Find(3).DOH.AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(8)),
                    VacationDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(3).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * vDays,
                    PersonalDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(3).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * pDays,
                    SickDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(3).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 6,
                    PersonalDaysUsedLifetime = 0,
                    SickDaysUsedLifetime = 2,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 0
                },
                //4: Percy Champlin, R&D Executive Director
                new WorkInfo()
                {
                    WorkInfoId = 4,
                    ContactId = 4,
                    PersonnelId = 4,
                    PositionId = 14,
                    Wage = 145000,
                    WorkEmail = "percy.champlin@company.com",
                    HasBenefits = true,
                    StartOfBenefits = context.PersonnelDbSet.Find(1).DOH.AddDays(90),
                    LastReview = context.PersonnelDbSet.Find(4).DOT.Value.Subtract(TimeSpan.FromDays(37)),
                    VacationDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * vDays,
                    PersonalDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * pDays,
                    SickDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 320,
                    PersonalDaysUsedLifetime = 54,
                    SickDaysUsedLifetime = 21,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 0

                },
                //5: Kailyn Douglas, R&D Director
                new WorkInfo()
                {
                    WorkInfoId = 5,
                    ContactId = 5,
                    PersonnelId = 5,
                    PositionId = 15,
                    Wage = 94000,
                    WorkEmail = "kailyn.douglas@company.com",
                    HasBenefits = false,
                    StartOfBenefits = context.PersonnelDbSet.Find(1).DOH.AddDays(90),
                    LastReview = default,
                    VacationDaysAccruedLifetime = default,
                    PersonalDaysAccruedLifetime = default,
                    SickDaysAccruedLifetime = default,
                    VacationDaysAccruedForPeriod = default,
                    PersonalDaysAccruedForPeriod = default,
                    SickDaysAccruedForPeriod = default,
                    VacationDaysUsedLifetime = default,
                    PersonalDaysUsedLifetime = default,
                    SickDaysUsedLifetime = default,
                    VacationDaysUsedForPeriod = default,
                    PersonalDaysUsedForPeriod = default,
                    SickDaysUsedForPeriod = default

                },
                //6: Ellis Reinger, Sales Associate
                new WorkInfo()
                {
                    WorkInfoId = 6,
                    ContactId = 6,
                    PersonnelId = 6,
                    PositionId = 8,
                    Wage = 32000,
                    WorkEmail = "ellis.reinger@company.com",
                    HasBenefits = default,
                    StartOfBenefits = default,
                    LastReview = context.PersonnelDbSet.Find(4).DOT.Value,
                    VacationDaysAccruedLifetime = default,
                    PersonalDaysAccruedLifetime = default,
                    SickDaysAccruedLifetime = default,
                    VacationDaysAccruedForPeriod = default,
                    PersonalDaysAccruedForPeriod = default,
                    SickDaysAccruedForPeriod = default,
                    VacationDaysUsedLifetime = default,
                    PersonalDaysUsedLifetime = default,
                    SickDaysUsedLifetime = default,
                    VacationDaysUsedForPeriod = default,
                    PersonalDaysUsedForPeriod = default,
                    SickDaysUsedForPeriod = default
                },
                //7: Su Lin Park, HR Executive Director
                new WorkInfo()
                {
                    WorkInfoId = 7,
                    ContactId = 7,
                    PersonnelId = 7,
                    PositionId = 1,
                    Wage = 115000,
                    WorkEmail = "sulin.park@company.com",
                    HasBenefits = true,
                    StartOfBenefits = context.PersonnelDbSet.Find(1).DOH.AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(21)),
                    VacationDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * vDays,
                    PersonalDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * pDays,
                    SickDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 180,
                    PersonalDaysUsedLifetime = 14,
                    SickDaysUsedLifetime = 3,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 1,
                    SickDaysUsedForPeriod = 0
                },
                //8: Mackenzie Lairmore, Compliance Associate
                new WorkInfo()
                {
                    WorkInfoId = 8,
                    ContactId = 8,
                    PersonnelId = 8,
                    PositionId = 21,
                    Wage = 35000,
                    WorkEmail = "mackenzie.lairmore@company.com",
                    HasBenefits = true,
                    StartOfBenefits = context.PersonnelDbSet.Find(1).DOH.AddDays(90),
                    LastReview = context.PersonnelDbSet.Find(4).DOT.Value.Subtract(TimeSpan.FromDays(47)),
                    VacationDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * vDays,
                    PersonalDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * pDays,
                    SickDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 45,
                    PersonalDaysUsedLifetime = 9,
                    SickDaysUsedLifetime = 1,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 0,
                    SickDaysUsedForPeriod = 0
                },
                //9: Ralph Kirlin, Compliance Supervisor
                new WorkInfo()
                {
                    WorkInfoId = 9,
                    ContactId = 9,
                    PersonnelId = 9,
                    PositionId = 20,
                    Wage = 58000,
                    WorkEmail = "ralph.kirlin@company.com",
                    HasBenefits = true,
                    StartOfBenefits = context.PersonnelDbSet.Find(1).DOH.AddDays(90),
                    LastReview = DateTime.Now.Subtract(TimeSpan.FromDays(2)),
                    VacationDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * vDays,
                    PersonalDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * pDays,
                    SickDaysAccruedLifetime = Convert.ToDouble(((context.WorkInfoDbSet.Find(1).StartOfBenefits.Year) - DateTime.Now.Year) * -12) * sDays,
                    VacationDaysAccruedForPeriod = vDays,
                    PersonalDaysAccruedForPeriod = pDays,
                    SickDaysAccruedForPeriod = sDays,
                    VacationDaysUsedLifetime = 19,
                    PersonalDaysUsedLifetime = 4,
                    SickDaysUsedLifetime = 0,
                    VacationDaysUsedForPeriod = 0,
                    PersonalDaysUsedForPeriod = 4,
                    SickDaysUsedForPeriod = 0

                },
                //10: Kat Mwanza, Sales Associate (Temp)
                new WorkInfo()
                {
                    WorkInfoId = 10,
                    ContactId = 10,
                    PersonnelId = 10,
                    PositionId = 9,
                    Wage = 34000,
                    WorkEmail = "kat.mwanza@company.com",
                    HasBenefits = false,
                    StartOfBenefits = default,
                    LastReview = default,
                    VacationDaysAccruedLifetime = default,
                    PersonalDaysAccruedLifetime = default,
                    SickDaysAccruedLifetime = default,
                    VacationDaysAccruedForPeriod = default,
                    PersonalDaysAccruedForPeriod = default,
                    SickDaysAccruedForPeriod = default,
                    VacationDaysUsedLifetime = default,
                    PersonalDaysUsedLifetime = default,
                    SickDaysUsedLifetime = default,
                    VacationDaysUsedForPeriod = default,
                    PersonalDaysUsedForPeriod = default,
                    SickDaysUsedForPeriod = default
                }
            );
        }
    }
}
