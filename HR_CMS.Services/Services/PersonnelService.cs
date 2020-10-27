using HR_CMS.Data;
using HR_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Services
{
    public class PersonnelService
    {
        //Create Personnel
        public bool CreatePersonnel(PersonnelCreate model)
        {
            var entity =
                new Personnel()
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    MiddleName = model.MiddleName,
                    SSN = model.SSN,
                    DOB = model.DOB,
                    DOH = model.DOH,
                    DOT = model.DOT,
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.PersonnelDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        //Get All Personnel
        public IEnumerable<PersonnelListItem> GetPersonnel()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .PersonnelDbSet
                    .Select(
                       e =>
                       new PersonnelListItem
                       {
                           PersonnelId = e.PersonnelId,
                           FirstName = e.FirstName,
                           MiddleName = e.MiddleName,
                           LastName = e.LastName,
                           SSN = e.SSN,
                           DOB = e.DOB,
                           DOH = e.DOH,
                           DOT = e.DOT,
                           //IsActive = e.IsActive
                       }
                    );
                return query.ToArray();
            }
        }

        //Get Personnel by ID
        public PersonnelDetail GetPersonnelById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .PersonnelDbSet
                    .Single(e => e.PersonnelId == id);
                return new PersonnelDetail
                {
                    PersonnelId = entity.PersonnelId,
                };
            }
        }

        //Edit Personnel
        public bool UpdatePersonnel(PersonnelDetail model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .PersonnelDbSet
                    .Single(e => e.PersonnelId == model.PersonnelId);

                entity.FirstName = model.FirstName;
                entity.MiddleName = model.MiddleName;
                entity.LastName = model.LastName;
                entity.SSN = model.SSN;
                entity.DOB = model.DOB;
                entity.DOH = model.DOH;

                return ctx.SaveChanges() == 1;
            }
        }

        //Archive Personnel
        public bool ArchivePersonnel(PersonnelArchive model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                    .PersonnelDbSet
                    .Single(e => e.PersonnelId == model.PersonnelId);

                entity.DOT = model.DOT;

                return ctx.SaveChanges() == 1;
            }
        }

        
        
        //STRETCH GOALS --GET BY ACTIVE / INACTIVE
        
        //Get All Active Personnel
        /*public IEnumerable<PersonnelListItem> GetActivePersonnel()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .PersonnelDbSet
                    .Where(e => e.IsActive == true)
                    .Select(
                       e =>
                       new PersonnelListItem
                       {
                           PersonnelId = e.PersonnelId,
                           FirstName = e.FirstName,
                           MiddleName = e.MiddleName,
                           LastName = e.LastName,
                           SSN = e.SSN,
                           DOB = e.DOB,
                           DOH = e.DOH,
                           DOT = e.DOT,
                           IsActive = e.IsActive
                       }
                    );
                return query.ToArray();
            }
        }*/

        //Get All Inactive Personnel
        /*public IEnumerable<PersonnelListItem> GetInactivePersonnel()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                    .PersonnelDbSet
                    .Where(e => e.IsActive == false)
                    .Select(
                       e =>
                       new PersonnelListItem
                       {
                           PersonnelId = e.PersonnelId,
                           FirstName = e.FirstName,
                           MiddleName = e.MiddleName,
                           LastName = e.LastName,
                           SSN = e.SSN,
                           DOB = e.DOB,
                           DOH = e.DOH,
                           DOT = e.DOT,
                           IsActive = e.IsActive
                       }
                    );
                return query.ToArray();
            }

        }*/
    }
}
