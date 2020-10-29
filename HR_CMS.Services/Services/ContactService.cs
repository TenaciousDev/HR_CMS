using HR_CMS.Data;
using HR_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Services
{
    public class ContactService
    {
        public bool CreateContact(ContactCreate model)
        {
            var entity =
                new 
                Contact()
                {
                    PersonnelId = model.PersonnelId,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email,
                    Address = model.Address
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.ContactDbSet.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<ContactListItem> GetContacts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx
                        .ContactDbSet
                        .Select(
                            e =>
                                new ContactListItem
                                {
                                    PersonnelId = e.PersonnelId,
                                    ContactId = e.ContactId,
                                    PhoneNumber = e.PhoneNumber,
                                    Email = e.Email,
                                    Address = e.Address
                                }
                        );

                return query.ToArray();
            }
        }

        public ContactDetail GetContactById(int id)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .ContactDbSet
                        .Single(e => e.ContactId == id);
                return
                    new ContactDetail
                    {
                        PersonnelId = entity.PersonnelId,
                        ContactId = entity.ContactId,
                        PhoneNumber = entity.PhoneNumber,
                        Email = entity.Email,
                        Address = entity.Address
                    };
            }
        }

        public IEnumerable<ContactListItem> GetContactForAllActive()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .ContactDbSet
                    .Where(e => e.Personnel.DOT == null)
                    .Select(
                    e =>
                    new ContactListItem
                    {
                        PersonnelId = e.PersonnelId,
                        ContactId = e.ContactId,
                        PhoneNumber = e.PhoneNumber,
                        Email = e.Email,
                        Address = e.Address
                    }
                    );
                return query.ToArray();
            }
        }

        public IEnumerable<ContactListItem> GetContactForAllInactive()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query = ctx
                    .ContactDbSet
                    .Where(e => e.Personnel.DOT != null)
                    .Select(
                    e =>
                    new ContactListItem
                    {
                        PersonnelId = e.PersonnelId,
                        ContactId = e.ContactId,
                        PhoneNumber = e.PhoneNumber,
                        Email = e.Email,
                        Address = e.Address
                    }
                    );
                return query.ToArray();
            }
        }

        public bool UpdateContact(ContactDetail model)
        {
            using (var ctx = new ApplicationDbContext())
            {
                var entity =
                    ctx
                        .ContactDbSet
                        .Single(e => e.PersonnelId == model.PersonnelId);
                entity.PhoneNumber = model.PhoneNumber;
                entity.Email = model.Email;
                entity.Address = model.Address;

                return ctx.SaveChanges() == 1;
            }
        }
    }
}
